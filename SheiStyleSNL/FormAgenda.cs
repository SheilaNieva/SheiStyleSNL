using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using SheiStyleSNL.Clases;
using Newtonsoft.Json;
using System.Collections;

namespace SheiStyleSNL
{
    public partial class FormAgenda : Form
    {
        DateTime fecha;
        
        //A este formulario le pasamos la fecha que hayamos elegido para nuestra cita
        public FormAgenda(DateTime fecha)
        {
            InitializeComponent();
            this.fecha = fecha;
        }

        //Al cargar el formulario llamamos a los siguientes metodos
        private void FormAgenda_Load(object sender, EventArgs e)
        {
            lblFecha.Text = fecha.ToShortDateString();
            cargar();
            cargarTabla();
        }

        //CONEXION A LA BASE DE DATOS
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "6vyUU5qV0nzcwGXgtnzkyPvZDBe8ykvBXH6UV53I",
            BasePath = "https://sheistyle-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient clien;

        private void cargar()
        {
            try
            {
                clien = new FireSharp.FirebaseClient(ifc);
            }
            catch (Exception)
            {
                throw; //no internet connection
            }
        }

        //Cargamos la tabla con las citas actuales
        private void cargarTabla()
        {
            String nombreC;
            //Consulta a la tabla Cita
            FirebaseResponse res = clien.Get(@"Cita");
            Dictionary<string, Cita> data = JsonConvert.DeserializeObject<Dictionary<string, Cita>>(res.Body.ToString());

            //Consulta a la tabla Cliente
            FirebaseResponse res1 = clien.Get(@"Cliente");
            Dictionary<string, Cliente> data1 = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(res1.Body.ToString());

            //RELLENAR TABLA CON SUS COLUMNAS
            dgvAgenda.Rows.Clear();
            dgvAgenda.Columns.Clear();
            dgvAgenda.Columns.Add("Fecha", "Fecha");
            dgvAgenda.Columns.Add("Hora", "Hora");
            dgvAgenda.Columns.Add("Cliente", "Cliente");
            dgvAgenda.Columns.Add("IDCliente", "IDCliente");
            dgvAgenda.Columns.Add("IDCita", "IDCita");
            dgvAgenda.Columns[3].Visible = false;
            dgvAgenda.Columns[4].Visible = false;

            //Recorremos la tabla Cita
            foreach (var item in data)
            {
                //Buscamos las citas en la base de datos que coincidan con la fecha seleccionada
                if(item.Value.fecha.ToShortDateString().Equals(fecha.ToShortDateString()))
                {
                    nombreC = nombreCliente(data1, item.Value.idCliente);//Sacamos el nombre del cliente
                    //Si esa cita pertenece a un cliente de la bbdd, lo mostramos en la tabla
                    if (!string.IsNullOrEmpty(nombreC))
                    {
                        dgvAgenda.Rows.Add(item.Value.fecha.ToShortDateString(), item.Value.fecha.ToShortTimeString(), nombreC, item.Value.idCliente, item.Value.idCita);
                    }
                }
            }

        }

        //Metodo que nos recupera el nombre del cliente de las citas que queramos mostrar en la tabla
        private String nombreCliente(Dictionary<string, Cliente> data1, string idCliente)
        {
            String nombreC = "";
            foreach (var item in data1)
            {
                if (item.Value.idCliente == idCliente)
                {
                    nombreC = item.Value.nombre;
                }
            }
            return nombreC;
        }

        //Si pinchamos en el botón atras, nos lleva de nuevo a formulario del calendario
        private void btnAtras_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormCalendario frmCalendario = new FormCalendario();
            frmCalendario.ShowDialog();
        }

        //Si pinchamos en el botón anadir cita, nos lleva a la siguiente pantalla, que es la de elegir servicios (pasandole la fecha seleccionada)
        private void btnAnadirCita_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormServicios frmServicios = new FormServicios(fecha);
            frmServicios.ShowDialog();
            
        }

        /*
         * Metodo que se produce cuando hacemos doble click sobre un registro de la tabla
         * */
        private void dgvAgenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String mensaje = "";
            //Si alguna fila de la tabla está seleccionada
            if (dgvAgenda.SelectedCells.Count > 0)
            {
                int fila = dgvAgenda.CurrentRow.Index;
                //Obtenemos el idCliente de la fila que hemos seleccionado
                String idCliente = dgvAgenda.Rows[fila].Cells[3].Value.ToString();

                //Hacemos una consulta a la tabla cliente y recuperamos el telefono del cliente
                FirebaseResponse res1 = clien.Get(@"Cliente");
                Dictionary<string, Cliente> data1 = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(res1.Body.ToString());
                foreach (var item in data1)
                {
                    if(idCliente.Equals(item.Value.idCliente))
                    mensaje ="Téfono de contacto del cliente: "+item.Value.telefono.ToString()+"\n";
                }

                //Hacemos una consulta a la tabla Cita para obtener la duracion de la cita
                String idCita = dgvAgenda.Rows[fila].Cells[4].Value.ToString();
                FirebaseResponse res = clien.Get(@"Cita");
                Dictionary<string, Cita> data = JsonConvert.DeserializeObject<Dictionary<string, Cita>>(res.Body.ToString());
                foreach (var item in data)
                {
                    if (idCita.Equals(item.Value.idCita))
                        mensaje = mensaje + " Duración de la cita: " + item.Value.duracion.ToString() +" h";
                }

                //Mostramos un mensaje con una informacion concreta de esa cita
                MessageBox.Show(mensaje);

            }
        }
    }
}
