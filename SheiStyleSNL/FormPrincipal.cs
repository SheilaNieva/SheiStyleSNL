﻿using System;
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
            FormNuevoCliente frmNuevoCliente = new FormNuevoCliente();
            frmNuevoCliente.Show();
        }
    }
}
