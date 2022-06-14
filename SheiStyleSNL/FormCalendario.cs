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
        DateTime fechaSeleccionada = DateTime.Now; //fecha seleccionada en el calendario
        DateTime fechaHoyDate = DateTime.Now; //fecha actual
        public FormCalendario()
        {
            InitializeComponent();
        }

        /*
         * Si pulsamos el botón atras, nos redirige al formulario principal
         */
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal frmPrincipal = new FormPrincipal();
            frmPrincipal.Show();
        }

        
        //Por defecto, seleccionamos la fecha de hoy
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            fechaSeleccionada = monthCalendar1.SelectionRange.Start;
        }

        //Al cargar el formulario, limitamos el calendario a que su rango empiece en la fecha actual
        private void FormCalendario_Load(object sender, EventArgs e)
        {
            monthCalendar1.MinDate = fechaHoyDate;
        }

        //Cuando elegimos un dia, si aceptamos, nos lleva a la siguiente pantalla, donde le pasamos el dia seleccionado
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAgenda frmAgenda = new FormAgenda(fechaSeleccionada);
            frmAgenda.ShowDialog();
        }
    }
}
