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

namespace SheiStyleSNL
{
    public partial class FormNuevoPedido : Form
    {
        public FormNuevoPedido()
        {
            InitializeComponent();
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
            FormPrincipal frmPrincipal = new FormPrincipal();
            frmPrincipal.Show();
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            Guid UUID = Guid.NewGuid();
            String idPedido = UUID.ToString();
            String descripcion = tbDescripcion.Text;
            float importe = float.Parse(tbImporte.Text);
            String fecha = DateTime.Now.ToString("dd/MM/yyyy");

            if(string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(importe.ToString())){
                MessageBox.Show("Debes rellenar todos los campos");
            }
            else
            {
                Pedido pedido = new Pedido(idPedido, descripcion, importe, fecha);
                SetResponse res = clien.Set(@"Pedido/" + idPedido, pedido);

                MessageBox.Show("El pedido se ha generado con éxito");

                tbDescripcion.Text = "";
                tbImporte.Text = "";
            }
        }
    }
}
