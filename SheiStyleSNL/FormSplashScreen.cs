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
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            FormPrincipal frmPrincipal = new FormPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void FormSplashScreen_Shown(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
