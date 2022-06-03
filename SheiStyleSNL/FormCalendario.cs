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
    public partial class FormCalendario : Form
    {
        DateTime fechaSeleccionada = DateTime.Now;
        DateTime fechaHoyDate = DateTime.Now;
        public FormCalendario()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal frmPrincipal = new FormPrincipal();
            frmPrincipal.Show();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            fechaSeleccionada = monthCalendar1.SelectionRange.Start;
        }

        private void FormCalendario_Load(object sender, EventArgs e)
        {
            monthCalendar1.MinDate = fechaHoyDate;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            this.Hide();

            FormAgenda frmAgenda = new FormAgenda(fechaSeleccionada);
            frmAgenda.ShowDialog();
        }
    }
}
