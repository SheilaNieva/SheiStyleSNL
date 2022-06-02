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
    public partial class FormAgenda : Form
    {
        String fecha;
        public FormAgenda(string fecha)
        {
            InitializeComponent();
            this.fecha = fecha;
        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {
            lblFecha.Text = fecha;
            cargarTabla();
        }

        private void cargarTabla()
        {
            dgvAgenda.Columns.Add("0", "Horas");
            dgvAgenda.Columns[0].Width = 100;
            dgvAgenda.Columns.Add("1", "Clientes");
            dgvAgenda.Columns[1].Width = 300;

            for (int i = 0; i < 7; i++)
            {
                dgvAgenda.Rows.Add();
            }
           
            dgvAgenda.Rows[0].Cells[0].Value = "10:00";
            dgvAgenda.Rows[1].Cells[0].Value = "11:00";
            dgvAgenda.Rows[2].Cells[0].Value = "12:00";
            dgvAgenda.Rows[3].Cells[0].Value = "13:00";
            dgvAgenda.Rows[4].Cells[0].Value = "14:00";
            dgvAgenda.Rows[5].Cells[0].Value = "17:00";
            dgvAgenda.Rows[6].Cells[0].Value = "18:00";
            dgvAgenda.Rows[7].Cells[0].Value = "19:00";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormCalendario frmCalendario = new FormCalendario();
            frmCalendario.ShowDialog();
        }
    }
}
