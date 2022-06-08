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
            SetResponse resCita = clien.Set(@"Cita/" + cita.idCita, cita);
            MessageBox.Show("Cita añadida con éxito");

            FirebaseResponse res1 = clien.Get(@"Empresa");
            Dictionary<string, Empresa> data = JsonConvert.DeserializeObject<Dictionary<string, Empresa>>(res1.Body.ToString());
            String idEmpresa = "";

            foreach (var item in data)
            {
                idEmpresa = item.Value.idEmpresa;
            }

            int citasAcumuladas = resCliente.citasAcumuladas +1;
            Cliente clienteModificado = new Cliente(resCliente.idCliente, resCliente.nombre, resCliente.apellidos, resCliente.telefono, 
                resCliente.correo, idEmpresa, citasAcumuladas);
            var res = clien.Update("Cliente/" + resCliente.idCliente, clienteModificado);
            this.Close();
            

        }
    }
}
