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
    public partial class FrmIngresos : Form
    {
        public FrmIngresos()
        {
            InitializeComponent();
            cargar();
            consultaIngresos();
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

        private void consultaIngresos()
        {
            String fecha = "";
            //ArrayList cantidad = new ArrayList();
           /* double[] cantidad;
            double[] tiempo;*/
            FirebaseResponse res = clien.Get(@"Ingreso");
            Dictionary<string, Ingreso> data = JsonConvert.DeserializeObject<Dictionary<string, Ingreso>>(res.Body.ToString());
            foreach (var item in data)
            {
                fecha = item.Value.fecha.ToShortDateString();
                MessageBox.Show(fecha);
            }
           /* var plt = new ScottPlot.Plot(200, 200);
            plt.AddScatter(cantidad, tiempo);*/

        }

    }
}
