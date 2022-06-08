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
        ArrayList citasHoy = new ArrayList();
        public FormAgenda(DateTime fecha)
        {
            InitializeComponent();
            this.fecha = fecha;
        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {
            lblFecha.Text = fecha.ToShortDateString();
            cargar();
            cargarTabla();
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


        private void cargarTabla()
        {
            String nombreC;
            FirebaseResponse res = clien.Get(@"Cita");
            Dictionary<string, Cita> data = JsonConvert.DeserializeObject<Dictionary<string, Cita>>(res.Body.ToString());

            FirebaseResponse res1 = clien.Get(@"Cliente");
            Dictionary<string, Cliente> data1 = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(res1.Body.ToString());

            //RELLENAR TABLAA
            dgvAgenda.Rows.Clear();
            dgvAgenda.Columns.Clear();
            dgvAgenda.Columns.Add("Fecha", "Fecha");
            dgvAgenda.Columns.Add("Hora", "Hora");
            dgvAgenda.Columns.Add("Cliente", "Cliente");

            foreach (var item in data)
            {
                if(item.Value.fecha.ToShortDateString().Equals(fecha.ToShortDateString()))
                {
                    nombreC = nombreCliente(data1, item.Value.idCliente);
                    dgvAgenda.Rows.Add(item.Value.fecha.ToShortDateString(), item.Value.fecha.ToShortTimeString(), nombreC);
                }
            }

        }

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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormCalendario frmCalendario = new FormCalendario();
            frmCalendario.ShowDialog();
        }

        private void btnAnadirCita_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormServicios frmServicios = new FormServicios(fecha);
            frmServicios.ShowDialog();
        }
    }
}
