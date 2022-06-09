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
        public FormPresupuesto(Cita cita)
        {
            InitializeComponent();
            cargar();
            this.cita = cita;
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
            this.Close();
            FormServicios frmServicios = new FormServicios(cita.fecha);
            frmServicios.Show();
        }

        private void FormPresupuesto_Load(object sender, EventArgs e)
        {
            lblPresupuesto.Text = cita.precioCita.ToString();
            comprobarDescuento();
            
        }

        private void comprobarDescuento()
        {
            String idCliente = cita.idCliente;
           // Cliente cliente = new Cliente(idCliente, nombre, apellidos, telefono, correo);
            var res = clien.Get("Cliente/" + idCliente);
            resCliente = res.ResultAs<Cliente>();

            int citas = resCliente.citasAcumuladas;
            MessageBox.Show(citas.ToString());
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
            FirebaseResponse resCita = clien.Get(@"Cita");
            Dictionary<string, Cita> dataCita = JsonConvert.DeserializeObject<Dictionary<string, Cita>>(resCita.Body.ToString());
            bool sinPagar = false;
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

                int citasAcumuladas = resCliente.citasAcumuladas + 1;
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


        }
    }
}
