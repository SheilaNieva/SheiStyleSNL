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
        //Declaracion de variables
        DateTime fecha;
        float prec;
        float dur;
        ArrayList listaIdCliente = new ArrayList();
        
        //Al llamar a este formulario, le pasamos la fecha elegida para nuestra cita
        public FormServicios(DateTime fecha)
        {
            InitializeComponent();
            this.fecha = fecha;
            cargar();
        }
        
        //CONEXION CON LA BD

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

         //El boton atras nos lleva de nuevo al formulario del listado de citas de un dia en concreto
        private void btnAtras_Click(object sender, EventArgs e)
        {


            this.Hide();
            FormAgenda frmAgenda = new FormAgenda(fecha);
            frmAgenda.ShowDialog();
        }

        /*
         * Metodo que se ejecuta al cargar el formulario de servicios
         */
        private void FormServicios_Load(object sender, EventArgs e)
        {
            //Rescatamos la fecha de la cita y la mostramos por pantalla
            lblFecha.Text = fecha.ToShortDateString();

            //Hacemos una consulta sobre la tabla Cliente
            FirebaseResponse res = clien.Get(@"Cliente");
            Dictionary<string, Cliente> data = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(res.Body.ToString());

            //Comprobamos que en la bbdd esten los campos nombre y apellidos rellenos
            foreach (var item in data)
            {
                if (null != item.Value.nombre && null != item.Value.apellidos)
                {
                    //Rellenamos el combo para elegir los clientes para la cita
                    cbCliente.Items.Add(item.Value.nombre + " " + item.Value.apellidos);
                    //De forma paralela, creamos un array con los id de los clientes
                    if (null != item.Value.idCliente)
                    {
                        listaIdCliente.Add(item.Value.idCliente);
                    }
                }
            }

            //Hacemos una consulta a la tabla Cita
            FirebaseResponse res1 = clien.Get(@"Cita");
            Dictionary<string, Cita> dataCita = JsonConvert.DeserializeObject<Dictionary<string, Cita>>(res1.Body.ToString());

            ArrayList listaHoras = new ArrayList();
            ArrayList listaDuracion = new ArrayList();

            //Recorremos todas las citas de la bbdd y nos quedamos con las que coincidan con la fecha seleccionada de nuestra nueva cita
            foreach (var item in dataCita)
            {
                if (item.Value.fecha.ToShortDateString() == fecha.ToShortDateString())
                {
                    //Guardamos en un array todas las fecha (y horas) de las citas de ese dia
                    listaHoras.Add(item.Value.fecha);
                    //Guardamos en otro array la duracion de las citas de ese dia
                    listaDuracion.Add(item.Value.duracion);
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

            
            //Recorremos el array que contiene todas las horas de citas de ese dia
            for (int i = 0; listaHoras.Count > i; i++)
            {
                DateTime fecha = (DateTime) listaHoras[i];//Guardamos las fechas (con horas) en un DateTime
                float duracion = float.Parse(listaDuracion[i].ToString()); //Guardamos la duracion de cada cita en un float
                string horaString = fecha.ToShortTimeString();//Guardamos la hora de las citas en un string
                duracion = duracion * 2; //x2 por cada duracion para que cuente las medias horas

               
                //Guardamos el indice del combo en el cual aparecen esas horas
                int indice;
                indice = cbHoras.FindString(horaString);

                //Recorremos la duracion de cada cita y vamos eliminando las horas que vaya a ocupar esa cita (por el indice)
                for (int j = 0; j < duracion; j++)
                {
                    if(indice < cbHoras.Items.Count && indice!=-1)
                    {
                        cbHoras.Items.RemoveAt(indice);
                    }
                }
            }

            //Por defecto, seleccionamos el primer cliente del combobox
            cbCliente.SelectedIndex = 0;
        }

        /*
         * Metodo que comprueba los servicios seleccionados, la duracion y el precio estimado
         */
        private String serviciosSeleccionados()
        {

            String servicioSeleccionado = "";            
            float duracionServicio = 0;
            float precio = 0;

            //Consulta a la tabla servicios
            FirebaseResponse res1 = clien.Get(@"Servicio");
            Dictionary<string, Servicio> data1 = JsonConvert.DeserializeObject<Dictionary<string, Servicio>>(res1.Body.ToString());

            //Comprueba cada uno de los checkBox seleccionados en el formulario 
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
            //Recogemos el precio y la duracion de la cita segun los servicios que hayamos seleccionado
            prec = precio;
            dur = duracionServicio;
            
            //Devuelve una lista con todos los servicios seleccionados para la nueva cita
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


            if (cbHoras.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar una hora para reservar tu cita");
            }
            else if (string.IsNullOrWhiteSpace(servicios))
            {
                MessageBox.Show("Debes seleccionar algún servicio para reservar tu cita");
            }
            else
            {
                //Hacemos una consulta a la tabla Cliente
                FirebaseResponse res = clien.Get(@"Cliente");
                Dictionary<string, Cliente> data = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(res.Body.ToString());
                bool correcto = true;

                // Construimos la cita que vamos a registrar en base de datos
                Cita cita = new Cita();
                Guid UUID = Guid.NewGuid();
                cita.idCita = UUID.ToString();
                cita.idCliente = listaIdCliente[cbCliente.SelectedIndex].ToString();
                cita.servicio = servicios;
                cita.fecha = calcularHorasMinutos(cbHoras.SelectedItem.ToString());
                cita.duracion = dur;
                cita.precioCita = prec;


                //Hacemos una consulta a la tabla Cita
                FirebaseResponse res1 = clien.Get(@"Cita");
                Dictionary<string, Cita> dataCita = JsonConvert.DeserializeObject<Dictionary<string, Cita>>(res1.Body.ToString());

                ArrayList listaHoras = new ArrayList();
                ArrayList listaDuracion = new ArrayList();

                //Guardamos las fecha y la duracion en 2 array
                foreach (var item in dataCita)
                {
                    if (item.Value.fecha.ToShortDateString() == fecha.ToShortDateString())
                    {
                        listaHoras.Add(item.Value.fecha);
                        listaDuracion.Add(item.Value.duracion);
                    }
                }

                bool coincide = false;

                DateTime horaCitaFinal = cita.fecha.AddHours(dur);

                //Recorremos las citas que hay ese dia y comprobamos las horas para que no se solapen las citas

                int totalMinutos = int.Parse((horaCitaFinal - cita.fecha).TotalMinutes.ToString());

                for (int i = 0; i < totalMinutos; i++)
                {
                //    cita.fecha.AddMinutes(i);
                    for (int j = 0; j < listaHoras.Count; j++)
                    {
                        if (cita.fecha.AddMinutes(i).ToString().Contains(listaHoras[j].ToString()))
                        {
                            coincide = true;
                        }
                    }

                }
            
                //Si todo va bien, llamamos al nuevo formulario y le pasamos la cita que acabamos de crear
                if (!coincide)
                {
                    FormPresupuesto frmPresupuesto = new FormPresupuesto(cita);
                    frmPresupuesto.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No hay tiempo disponible para su cita. Por favor seleccione una hora distinta o una fecha distinta.");
                }
            }

            
        
                
            
        }
    }
}
