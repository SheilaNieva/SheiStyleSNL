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
            /*frmIngresos.Hide();
            frmDatosEmpresa = new FrmDatosEmpresa();
            frmDatosEmpresa.MdiParent = this;
            frmDatosEmpresa.Dock = DockStyle.Fill;
            frmDatosEmpresa.Show();*/
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "FrmDatosEmpresa")
                {
                    DialogResult dr = MessageBox.Show("¿Desea salir de este formulario?", "Atención",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        FrmDatosEmpresa frmDatosEmpresa = new FrmDatosEmpresa();
                        frmDatosEmpresa.MdiParent = this;
                        frmDatosEmpresa.Dock = DockStyle.Fill;
                        frmDatosEmpresa.Show();
                    }

                }
            }
            else
            {
                FrmDatosEmpresa frmDatosEmpresa = new FrmDatosEmpresa();
                frmDatosEmpresa.MdiParent = this;
                frmDatosEmpresa.Dock = DockStyle.Fill;
                frmDatosEmpresa.Show();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal frmPrincipal = new FormPrincipal();
            frmPrincipal.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            frmDatosEmpresa = new FrmDatosEmpresa();
            frmDatosEmpresa.MdiParent = this;
            frmDatosEmpresa.Dock = DockStyle.Fill;
            frmDatosEmpresa.Show();
            

        }

        private void lblIngresos_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "FrmIngresos")
                {
                    DialogResult dr = MessageBox.Show("¿Desea salir de este formulario?", "Atención",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        FrmIngresos frmIngresos = new FrmIngresos();
                        frmIngresos.MdiParent = this;
                        frmIngresos.Dock = DockStyle.Fill;
                        frmIngresos.Show();
                    }

                }
            }
            else
            {
                FrmIngresos frmIngresos = new FrmIngresos();
                frmIngresos.MdiParent = this;
                frmIngresos.Dock = DockStyle.Fill;
                frmIngresos.Show();
            }
            /* frmDatosEmpresa.Hide();
            // frmIngresos = new FrmIngresos();
             frmIngresos.MdiParent = this;
             frmIngresos.Dock = DockStyle.Fill;
             frmIngresos.Show();*/
        }

        private void lblGastos_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "FrmGastos")
                {
                    DialogResult dr = MessageBox.Show("¿Desea salir de este formulario?", "Atención",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        FrmGastos frm_gastos = new FrmGastos();
                        frm_gastos.MdiParent = this;
                        frm_gastos.Dock = DockStyle.Fill;
                        frm_gastos.Show();
                    }

                }
            }
            else
            {
                FrmGastos frm_gastos = new FrmGastos();
                frm_gastos.MdiParent = this;
                frm_gastos.Dock = DockStyle.Fill;
                frm_gastos.Show();
            }
        }
    }
}
