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
    public partial class FormListadoCitasCliente : Form
    {
        Cliente c;
        public FormListadoCitasCliente(Cliente c)
        {
            InitializeComponent();
            this.c = c;
            cargar();
            cargarListado();
        }

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


        private void cargarListado()
        {
            FirebaseResponse res = clien.Get(@"Cita");
            Dictionary<string, Cita> data = JsonConvert.DeserializeObject<Dictionary<string, Cita>>(res.Body.ToString());
            rellenarListado(data);
        }

        private void rellenarListado(Dictionary<string, Cita> data)
        {
            
                dibujarColumnasLista();
               // ArrayList row = new ArrayList();

                foreach (var item in data)
                {
                    if (item.Value.idCliente == c.idCliente)
                    {
                    if (item.Value.pagado == false)
                    {
                       String[] row = { item.Value.fecha.ToShortDateString(), item.Value.fecha.ToShortTimeString(), item.Value.servicio, item.Value.precioCita.ToString(), "No", item.Value.idCita };
                        var itemListView = new ListViewItem(row);
                        listCitaClientes.Items.Add(itemListView);
                    }
                    else {
                        //En un array de String introducimos los datos de cada cliente
                       String[] row = { item.Value.fecha.ToShortDateString(), item.Value.fecha.ToShortTimeString(), item.Value.servicio, item.Value.precioCita.ToString(), "Si", item.Value.idCita };
                        //Introducimos los items (clientes) en el listado
                        var itemListView = new ListViewItem(row);
                        listCitaClientes.Items.Add(itemListView);
                    }
                    }
                }
        }

        private void dibujarColumnasLista()
        {
            listCitaClientes.Clear();
            listCitaClientes.Columns.Clear();

            listCitaClientes.Columns.Add("Fecha", 150);
            listCitaClientes.Columns.Add("Hora", 150);
            listCitaClientes.Columns.Add("Servicios", 150);
            listCitaClientes.Columns.Add("Precio", 150);
            listCitaClientes.Columns.Add("Pagado", 150);
            listCitaClientes.Columns.Add("Id", 0);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            FormListadoClientes formListadoClientes = new FormListadoClientes();
            formListadoClientes.Show();
        }

        private void listCitaClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Obtenemos la fila que pulsamos
            int fila = listCitaClientes.FocusedItem.Index;
            //Obtenemos el idCliente de la fila que hemos seleccionado
            String idCita = listCitaClientes.Items[fila].SubItems[5].Text;

            //Obtenemos el cliente que tenfa ese id y lo devolvemos
            FirebaseResponse res = clien.Get(@"Cita/" + idCita);
            Cita resCita = res.ResultAs<Cita>();
            if (resCita.pagado)
            {
                MessageBox.Show("Cita pagada");
            }
            else
            {
                Cita citaModificada = new Cita(resCita.idCita, resCita.idCliente, resCita.servicio, resCita.fecha, resCita.duracion, resCita.precioCita, true);
                var res1 = clien.Update("Cita/" + idCita, citaModificada);
                MessageBox.Show("Su pago se ha realizado con éxito: "+resCita.precioCita+ " €");
                generarIngreso(idCita, resCita.precioCita);
                cargarListado();
                
            }
        }

        private void generarIngreso(string idCita, float precioCita)
        {
           
            Guid UUID = Guid.NewGuid();
            String idIngreso = UUID.ToString();
            DateTime fecha = DateTime.Now;
            float cantidad = precioCita;
            String idCitaIngreso = idCita;


            Ingreso ing = new Ingreso(idIngreso, fecha, cantidad, idCitaIngreso);
            SetResponse res = clien.Set(@"Ingreso/" + idIngreso, ing);

            MessageBox.Show("Ingreso generado con éxito");
        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            //Obtenemos la fila que pulsamos
            if(null != listCitaClientes.FocusedItem)
            {
                int fila = listCitaClientes.FocusedItem.Index;
                //Obtenemos el idCliente de la fila que hemos seleccionado
                String idCita = listCitaClientes.Items[fila].SubItems[5].Text;

                FirebaseResponse res = clien.Get(@"Cita/" + idCita);
                Cita resCita = res.ResultAs<Cita>();
                if (!resCita.pagado)
                {
                    var eliminar = clien.Delete("Cita/" + resCita.idCita);
                }
                else
                {
                    MessageBox.Show("Esta cita está pagada y archivada. No se puede eliminar");
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una cita para poder eliminarla");
            }
        }
    }
}
