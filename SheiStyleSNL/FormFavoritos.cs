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
using System.Collections;

namespace SheiStyleSNL
{
    public partial class FormFavoritos : Form
    {
        public FormFavoritos()
        {
            InitializeComponent();
            cargar();
            verServicios();
        }

        private void verServicios()
        {
            int lavado = 0;
            int recogido = 0;
            int mechas = 0;
            int tinte = 0;
            int alisado = 0;
            int corte = 0;
            int decoloracion = 0;
            int permanente = 0;
            FirebaseResponse res = clien.Get(@"Cita");
            Dictionary<string, Cita> data = JsonConvert.DeserializeObject<Dictionary<string, Cita>>(res.Body.ToString());
            foreach (var item in data)
            {
                if (item.Value.servicio.Contains("Lavado"))
                {
                    lavado++;
                }
                if (item.Value.servicio.Contains("Recogido"))
                {
                    recogido++;
                }
                if (item.Value.servicio.Contains("Mechas"))
                {
                    mechas++;
                }
                if (item.Value.servicio.Contains("Tinte"))
                {
                    tinte++;
                }
                if (item.Value.servicio.Contains("Corte"))
                {
                    corte++;
                }
                if (item.Value.servicio.Contains("Alisado"))
                {
                    alisado++;
                }
                if (item.Value.servicio.Contains("Permanente"))
                {
                    permanente++;
                }
                if (item.Value.servicio.Contains("Decoloracion"))
                {
                    decoloracion++;
                }
            }
          //  MessageBox.Show("alisado " + alisado + " recogido " + recogido + " mechas " + mechas + " tinte " + tinte + " corte " + corte + " alisado " + alisado);

            double[] servGrafico = {lavado, recogido, mechas, tinte, corte, alisado, permanente, decoloracion };

            var pie = grafServicios.Plot.AddPie(servGrafico);
            grafServicios.Refresh();
            pie.ShowValues = true;

            lblLavados.Text = lavado.ToString();
            lblCortes.Text = corte.ToString();
            lblAlisados.Text = alisado.ToString();
            lblMechas.Text = mechas.ToString();
            lblDeco.Text = decoloracion.ToString();
            lblPermanente.Text = permanente.ToString();
            lblRecogidos.Text = recogido.ToString();
            lblTinte.Text = tinte.ToString();


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
    }
}
