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

using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using SheiStyleSNL.Clases;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace SheiStyleSNL
{
    public partial class FormPresupuesto : Form
    {
        Cita cita;
        Cliente resCliente;

        //Formulario que recibe una cita para registrar en la bd
        public FormPresupuesto(Cita cita)
        {
            InitializeComponent();
            cargar();
            this.cita = cita;
        }

        //CONEXION A LA BD
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

        //Si pulsamos en el boton atras, nos lleva al formulario para poder elegir servicios
        private void btnAtras_Click(object sender, EventArgs e)
        {
            
            FormServicios frmServicios = new FormServicios(cita.fecha);
            frmServicios.Show();
            this.Hide();
        }

        //Cargamos el formulario con el precio de la cita que hemos generado en el otro formulario
        private void FormPresupuesto_Load(object sender, EventArgs e)
        {
            lblPresupuesto.Text = cita.precioCita.ToString();
            comprobarDescuento();
            
        }

        //Metodo que comprueba si al cliente por cada 3 citas le corresponde un 30% de descuento o no
        private void comprobarDescuento()
        {
            String idCliente = cita.idCliente;
            var res = clien.Get("Cliente/" + idCliente);
            resCliente = res.ResultAs<Cliente>();

            int citas = resCliente.citasAcumuladas;
            if(citas % 3 == 0)
            { 
                lblDescuento.Text = "30";
                float total = cita.precioCita - (cita.precioCita * 0.3f);
                lblTotal.Text = total.ToString();
            }
            else
            {
                lblDescuento.Text = "-";
                lblTotal.Text = cita.precioCita.ToString(); ;
            }

        }

        private void btnReservarCita_Click(object sender, EventArgs e)
        {
            //Hacemo suna consulta a la tabla Cita
            FirebaseResponse resCita = clien.Get(@"Cita");
            Dictionary<string, Cita> dataCita = JsonConvert.DeserializeObject<Dictionary<string, Cita>>(resCita.Body.ToString());
            bool sinPagar = false;
            //Comprobamos si las citas de ese cliente estan o no pagadas
            foreach (var item in dataCita)
            {
                if (item.Value.idCliente == resCliente.idCliente)
                {
                    if (item.Value.pagado == false)
                    {
                        sinPagar = true;
                    }
                }
            }

            //Si no debe nada, creamos una cita correctamente
            if (!sinPagar)
            {
                SetResponse resC = clien.Set(@"Cita/" + cita.idCita, cita);
                MessageBox.Show("Cita añadida con éxito");

                FirebaseResponse resE = clien.Get(@"Empresa");
                Dictionary<string, Empresa> dataE = JsonConvert.DeserializeObject<Dictionary<string, Empresa>>(resE.Body.ToString());
                String idEmpresa = "";

                foreach (var item1 in dataE)
                {
                    idEmpresa = item1.Value.idEmpresa;
                }

                //Anadimos una cita al cumulo de citas de ese cliente, para poder hacerle el descuento cuando corresponda
                int citasAcumuladas = resCliente.citasAcumuladas + 1;

                //Modificamos el cliente para sumarle la cita
                Cliente clienteModificado = new Cliente(resCliente.idCliente, resCliente.nombre, resCliente.apellidos, resCliente.telefono,
                    resCliente.correo, idEmpresa, citasAcumuladas);
                var res2 = clien.Update("Cliente/" + resCliente.idCliente, clienteModificado);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se puede reservar esta cita, porque tiene citas anteriores sin pagar");

                this.Close();
            }

            FormPrincipal frmPrincipal = new FormPrincipal();
            frmPrincipal.Show();
        }
    }
}
