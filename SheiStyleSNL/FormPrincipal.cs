using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheiStyleSNL
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Estás seguro?", "Salir", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormListadoClientes frmListadoCliente = new FormListadoClientes();
            frmListadoCliente.Show();
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormFavoritos frmFavoritos = new FormFavoritos();
            frmFavoritos.Show();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormNuevoPedido frmPedido = new FormNuevoPedido();
            frmPedido.ShowDialog();
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormMenu frmMenu = new FormMenu();
            frmMenu.Show();
        }
    }
}
