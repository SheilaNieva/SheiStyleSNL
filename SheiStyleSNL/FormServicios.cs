using FireSharp.Config;
using FireSharp.Interfaces;
using SheiStyleSNL.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Response;
using Newtonsoft.Json;
using System.Collections;

namespace SheiStyleSNL
{
    public partial class FormServicios : Form
    {
        String fecha;
        ArrayList listaIdCliente = new ArrayList();
        public float duracionServicio = 0;
        public FormServicios(string fecha)
        {
            InitializeComponent();
            this.fecha = fecha;
            cargar();
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


        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormAgenda frmAgenda = new FormAgenda(fecha);
            frmAgenda.ShowDialog();
        }

        private void FormServicios_Load(object sender, EventArgs e)
        {
            lblFecha.Text = fecha;

            // Consultamos base de datos para obtener los nombres de clientes
            FirebaseResponse res = clien.Get(@"Cliente");
            Dictionary<string, Cliente> data = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(res.Body.ToString());


            foreach (var item in data)
            {
                if (null != item.Value.nombre && null != item.Value.apellidos)
                {
                    cbCliente.Items.Add(item.Value.nombre + " " + item.Value.apellidos);
                    if (null != item.Value.idCliente)
                    {
                        listaIdCliente.Add(item.Value.idCliente);
                    }
                }
            }
            cbCliente.SelectedIndex = 0;
        }

        

        private String serviciosSeleccionados() {

            String servicioSeleccionado = "";

            if (cbLavado.Checked)
            {
                servicioSeleccionado = servicioSeleccionado + cbLavado.Text + ",";
                duracionServicio = duracionServicio + 1;
            }

            if (cbCorte.Checked)
            {
                servicioSeleccionado = servicioSeleccionado + cbCorte.Text + ",";
                duracionServicio = duracionServicio + 0.5f;
            }

            if (cbTinte.Checked)
            {
                servicioSeleccionado = servicioSeleccionado + cbTinte.Text + ",";
            }

            if (cbMechas.Checked)
            {
                servicioSeleccionado = servicioSeleccionado + cbMechas.Text + ",";
            }

            if (cbDecoloracion.Checked)
            {
                servicioSeleccionado = servicioSeleccionado + cbDecoloracion.Text + ",";
            }

            if (cbAlisado.Checked)
            {
                servicioSeleccionado = servicioSeleccionado + cbLavado.Text + ",";
            }

            if (cbPermanente.Checked)
            {
                servicioSeleccionado = servicioSeleccionado + cbLavado.Text + ",";
            }

            if (cbRecogido.Checked)
            {
                servicioSeleccionado = servicioSeleccionado + cbLavado.Text + ",";
            }

            return servicioSeleccionado;
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = clien.Get(@"Cliente");
            Dictionary<string, Cliente> data = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(res.Body.ToString());

            // Construimos la cita que vamos a registrar en base de datos
            Cita cita = new Cita();
            Guid UUID = Guid.NewGuid();
            cita.idCita = UUID.ToString();
            cita.idCliente = listaIdCliente[cbCliente.SelectedIndex].ToString();
            cita.servicio = serviciosSeleccionados();
            cita.fecha = fecha;
            cita.duracion = duracionServicio;
            cita.precioCita = 12;

            SetResponse resCita = clien.Set(@"Cita/" + cita.idCita, cita);
        }
    }
}
