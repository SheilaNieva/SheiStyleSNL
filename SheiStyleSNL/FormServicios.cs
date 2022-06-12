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
        DateTime fecha;
        float prec;
        float dur;
        ArrayList listaIdCliente = new ArrayList();
        
        public FormServicios(DateTime fecha)
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
            lblFecha.Text = fecha.ToShortDateString();

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

            FirebaseResponse res1 = clien.Get(@"Cita");
            Dictionary<string, Cita> dataCita = JsonConvert.DeserializeObject<Dictionary<string, Cita>>(res1.Body.ToString());

            ArrayList listaHoras = new ArrayList();
            ArrayList listaDuracion = new ArrayList();
            ArrayList listaHorasBBDD = new ArrayList();

            foreach (var item in dataCita)
            {
                if (item.Value.fecha.ToShortDateString() == fecha.ToShortDateString())
                {
                    //listaHoras.Add((item.Value.fecha.Hour + ":" + item.Value.fecha.Minute).ToString());
                    listaHoras.Add(item.Value.fecha);
                    listaDuracion.Add(item.Value.duracion);
                    //listaHorasBBDD.Add((fecha.Hour + ":" + fecha.Minute).ToString());
                }
            }

            // Aniadimos todos los campos al combo de horas
            cbHoras.Items.Add("8:00");
            cbHoras.Items.Add("8:30");
            cbHoras.Items.Add("9:00");
            cbHoras.Items.Add("9:30");
            cbHoras.Items.Add("10:00");
            cbHoras.Items.Add("10:30");
            cbHoras.Items.Add("11:00");
            cbHoras.Items.Add("11:30");
            cbHoras.Items.Add("12:00");
            cbHoras.Items.Add("12:30");
            cbHoras.Items.Add("13:00");
            cbHoras.Items.Add("13:30");
            cbHoras.Items.Add("14:00");
            /* cbHoras.Items.Add("8:00");
             cbHoras.Items.Add("8:00");
             cbHoras.Items.Add("8:00");
             cbHoras.Items.Add("8:00");*/

            int noExiste = -1;

            for (int i = 0; listaHoras.Count > i; i++)
            {
                DateTime fecha = (DateTime) listaHoras[i];
                float duracion = float.Parse(listaDuracion[i].ToString());
                float hora = fecha.Hour;
                string horaString = fecha.ToShortTimeString();

                

                duracion = duracion * 2;

               // int indice = cbHoras.Items.IndexOf(horaString);
               // int indice = cbHoras.FindString(horaString);
                 int indice;

                /*for (int j = indice; j < duracion; j++)
                  {
                      cbHoras.Items.RemoveAt(j);
                  }*/

                indice = cbHoras.FindString(horaString);

                for (int j = 0; j < duracion; j++)
                {
                    if(indice < cbHoras.Items.Count)
                    {
                        cbHoras.Items.RemoveAt(indice);
                    }
                    
                }









                /*
                if (!fecha.Contains("8:00"))
                {
                    cbHoras.Items.Add("8:00");
                }

                if (!fecha.Contains("8:30"))
                {
                    cbHoras.Items.Add("8:30");
                }
                if (!fecha.Contains("9:00"))
                {
                    cbHoras.Items.Add("9:00");
                }
                if (!fecha.Contains("9:30"))
                {
                    cbHoras.Items.Add("9:30");
                }

                if (!fecha.Contains("10:00"))
                {
                    cbHoras.Items.Add("10:00");
                }

                if (!fecha.Contains("10:30"))
                {
                    cbHoras.Items.Add("10:30");
                }

                if (!fecha.Contains("11:00"))
                {
                    cbHoras.Items.Add("11:00");
                }

                if (!fecha.Contains("11:30"))
                {
                    cbHoras.Items.Add("11:30");
                }

                if (!fecha.Contains("12:00"))
                {
                    cbHoras.Items.Add("12:00");
                }

                if (!fecha.Contains("12:30"))
                {
                    cbHoras.Items.Add("12:30");
                }

                if (!fecha.Contains("13:00"))
                {
                    cbHoras.Items.Add("13:00");
                }

                if (!fecha.Contains("13:30"))
                {
                    cbHoras.Items.Add("13:30");
                }

                if (!fecha.Contains("14:00"))
                {
                    cbHoras.Items.Add("14:00");
                }*/

            }

            cbCliente.SelectedIndex = 0;


        }


        private String serviciosSeleccionados()
        {

            String servicioSeleccionado = "";            
            float duracionServicio = 0;
            float precio = 0;
            FirebaseResponse res1 = clien.Get(@"Servicio");
            Dictionary<string, Servicio> data1 = JsonConvert.DeserializeObject<Dictionary<string, Servicio>>(res1.Body.ToString());


            foreach (var item in data1)
            {

                if (cbLavado.Checked && cbLavado.Text.Equals(item.Value.nombre))
                {
                    servicioSeleccionado = servicioSeleccionado + cbLavado.Text + ",";
                    duracionServicio = duracionServicio + item.Value.duracion;
                    precio = precio + item.Value.precio;
                }

                if (cbCorte.Checked && cbCorte.Text.Equals(item.Value.nombre))
                {
                    servicioSeleccionado = servicioSeleccionado + cbCorte.Text + ",";
                    duracionServicio = duracionServicio + item.Value.duracion;
                    precio = precio + item.Value.precio;

                }

                if (cbTinte.Checked && cbTinte.Text.Equals(item.Value.nombre))
                {
                    servicioSeleccionado = servicioSeleccionado + cbTinte.Text + ",";
                    duracionServicio += item.Value.duracion;
                    precio = precio + item.Value.precio;
                }

                if (cbMechas.Checked && cbMechas.Text.Equals(item.Value.nombre))
                {
                    servicioSeleccionado = servicioSeleccionado + cbMechas.Text + ",";
                    duracionServicio = duracionServicio + item.Value.duracion;
                    precio = precio + item.Value.precio;
                }

                if (cbDecoloracion.Checked && cbDecoloracion.Text.Equals(item.Value.nombre))
                {
                    servicioSeleccionado = servicioSeleccionado + cbDecoloracion.Text + ",";
                    duracionServicio += item.Value.duracion;
                    precio = precio + item.Value.precio;
                }

                if (cbAlisado.Checked && cbAlisado.Text.Equals(item.Value.nombre))
                {
                    servicioSeleccionado = servicioSeleccionado + cbAlisado.Text + ",";
                    duracionServicio += item.Value.duracion;
                    precio = precio + item.Value.precio;
                }

                if (cbPermanente.Checked && cbPermanente.Text.Equals(item.Value.nombre))
                {
                    servicioSeleccionado = servicioSeleccionado + cbPermanente.Text + ",";
                    duracionServicio += item.Value.duracion;
                    precio = precio + item.Value.precio;
                }

                if (cbRecogido.Checked && cbRecogido.Text.Equals(item.Value.nombre) )
                {
                    servicioSeleccionado = servicioSeleccionado + cbRecogido.Text + ",";
                    duracionServicio += item.Value.duracion;
                    precio = precio + item.Value.precio;
                }

                if (cbPedicura.Checked && cbPedicura.Text.Equals(item.Value.nombre) )
                {
                    servicioSeleccionado = servicioSeleccionado + cbPedicura.Text + ",";
                    duracionServicio += item.Value.duracion;
                    precio = precio + item.Value.precio;
                }
                if (cbGel.Checked && cbGel.Text.Equals(item.Value.nombre))
                {
                    servicioSeleccionado = servicioSeleccionado + cbGel.Text + ",";
                    duracionServicio += item.Value.duracion;
                    precio = precio + item.Value.precio;
                }
                if (cbAcrilicas.Checked && cbAcrilicas.Text.Equals(item.Value.nombre))
                {
                    servicioSeleccionado = servicioSeleccionado + cbAcrilicas.Text + ",";
                    duracionServicio += item.Value.duracion;
                    precio = precio + item.Value.precio;
                }
                if (cbPermanentes.Checked && cbPermanentes.Text.Equals(item.Value.nombre) )
                {
                    servicioSeleccionado = servicioSeleccionado + cbPermanentes.Text + ",";
                    duracionServicio += item.Value.duracion;
                    precio = precio + item.Value.precio;
                }
                if (cbBigote.Checked && cbBigote.Text.Equals(item.Value.nombre) )
                {
                    servicioSeleccionado = servicioSeleccionado + cbBigote.Text + ",";
                    duracionServicio += item.Value.duracion;
                    precio = precio + item.Value.precio;
                }
                if (cbCejas.Checked && cbCejas.Text.Equals(item.Value.nombre))
                {
                    servicioSeleccionado = servicioSeleccionado + cbCejas.Text + ",";
                    duracionServicio += item.Value.duracion;
                    precio = precio + item.Value.precio;
                }
                if (cbPiernas.Checked && cbPiernas.Text.Equals(item.Value.nombre))
                {
                    servicioSeleccionado = servicioSeleccionado + cbPiernas.Text + ",";
                    duracionServicio += item.Value.duracion;
                    precio = precio + item.Value.precio;
                }
                if (cbBrazos.Checked && cbBrazos.Text.Equals(item.Value.nombre) )
                {
                    servicioSeleccionado = servicioSeleccionado + cbBrazos.Text + ",";
                    duracionServicio += item.Value.duracion;
                    precio = precio + item.Value.precio;
                }
                if (cbIntima.Checked && cbIntima.Text.Equals(item.Value.nombre))
                {
                    servicioSeleccionado = servicioSeleccionado + cbIntima.Text + ",";
                    duracionServicio += item.Value.duracion;
                    precio = precio + item.Value.precio;
                }
                if (cbAxilas.Checked && cbAxilas.Text.Equals(item.Value.nombre))
                {
                    servicioSeleccionado = servicioSeleccionado + cbAxilas.Text + ",";
                    duracionServicio += item.Value.duracion;
                    precio = precio + item.Value.precio;
                }
                if (cbAfeitado.Checked && cbAfeitado.Text.Equals(item.Value.nombre))
                {
                    servicioSeleccionado = servicioSeleccionado + cbAfeitado.Text + ",";
                    duracionServicio += item.Value.duracion;
                    precio = precio + item.Value.precio;
                }
                if (cbRecorte.Checked && cbRecorte.Text.Equals(item.Value.nombre))
                {
                    servicioSeleccionado = servicioSeleccionado + cbRecorte.Text + ",";
                    duracionServicio += item.Value.duracion;
                    precio = precio + item.Value.precio;
                }

            }
            prec = precio;
            dur = duracionServicio;
            
            return servicioSeleccionado;
            
        }
        // Metodo para calcular la hora y los minutos seleccionados
        private DateTime calcularHorasMinutos(String horaSeleccionada)
        {
            string[] fechaSplit = horaSeleccionada.Split(':');

            int hora = Int32.Parse(fechaSplit[0]);
            int minutos = Int32.Parse(fechaSplit[1]);

            DateTime fechaCita = new DateTime(fecha.Year, fecha.Month, fecha.Day, hora, minutos, 00);

            return fechaCita;
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            String servicios = serviciosSeleccionados();
            

            if(cbHoras.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar una hora para reservar tu cita");
            }else if (string.IsNullOrWhiteSpace(servicios))
            {
                MessageBox.Show("Debes seleccionar algún servicio para reservar tu cita");
            }
            else
            {
                FirebaseResponse res = clien.Get(@"Cliente");
                Dictionary<string, Cliente> data = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(res.Body.ToString());

                // Construimos la cita que vamos a registrar en base de datos
                Cita cita = new Cita();
                Guid UUID = Guid.NewGuid();
                cita.idCita = UUID.ToString();
                cita.idCliente = listaIdCliente[cbCliente.SelectedIndex].ToString();
                cita.servicio = servicios;
                cita.fecha = calcularHorasMinutos(cbHoras.SelectedItem.ToString());
                cita.duracion = dur;
                cita.precioCita = prec;

                MessageBox.Show("Servicios seleccionados : " + cita.servicio + " precio estimado: " + cita.precioCita + " duracion: " + cita.duracion);
                FormPresupuesto frmPresupuesto = new FormPresupuesto(cita);
                frmPresupuesto.Show();
            }
        }
    }
}
