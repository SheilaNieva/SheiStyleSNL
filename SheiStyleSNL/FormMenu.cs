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
    public partial class FormMenu : Form
    {
        
        FrmIngresos frmIngresos = new FrmIngresos();
        FrmDatosEmpresa frmDatosEmpresa = new FrmDatosEmpresa();
        public FormMenu()
        {
            InitializeComponent();
        }

        private void lblDatosEmpresa_Click(object sender, EventArgs e)
        {
            frmIngresos.Hide();
            frmDatosEmpresa = new FrmDatosEmpresa();
            frmDatosEmpresa.MdiParent = this;
            frmDatosEmpresa.Dock = DockStyle.Fill;
            frmDatosEmpresa.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal frmPrincipal = new FormPrincipal();
            frmPrincipal.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            //frmDatosEmpresa = new FrmDatosEmpresa();
            frmDatosEmpresa.MdiParent = this;
            frmDatosEmpresa.Dock = DockStyle.Fill;
            frmDatosEmpresa.Show();
        }

        private void lblIngresos_Click(object sender, EventArgs e)
        {
            frmDatosEmpresa.Hide();
           // frmIngresos = new FrmIngresos();
            frmIngresos.MdiParent = this;
            frmIngresos.Dock = DockStyle.Fill;
            frmIngresos.Show();
        }
    }
}
