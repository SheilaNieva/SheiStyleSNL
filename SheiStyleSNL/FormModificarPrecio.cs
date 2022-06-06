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
using System.Text.RegularExpressions;

namespace SheiStyleSNL
{
    public partial class FormModificarPrecio : Form
    {
        String idServicio;
        public FormModificarPrecio(string idServicio)
        {
            InitializeComponent();
            this.idServicio = idServicio;
            cargar();
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

        private void FormModificarPrecio_Load(object sender, EventArgs e)
        {
            String nomSector = obtenerNombreSector();
           

            FirebaseResponse res = clien.Get(@"Servicio");
            Dictionary<string, Servicio> data = JsonConvert.DeserializeObject<Dictionary<string, Servicio>>(res.Body.ToString());

            foreach (var item in data)
            {
                if(item.Value.idServicio == idServicio)
                {
                    tbServicio.Text = item.Value.nombre;
                    tbSector.Text = nomSector;
                    tbPrecio.Text = item.Value.precio.ToString();
                }
            }
        }

        private string obtenerNombreSector()
        {
            String nombreSector ="";
            String idSector;
            FirebaseResponse res = clien.Get(@"Servicio");
            Dictionary<string, Servicio> data = JsonConvert.DeserializeObject<Dictionary<string, Servicio>>(res.Body.ToString());
            foreach (var item in data)
            {
                if (item.Value.idServicio.Contains(idServicio))
                {
                    idSector = item.Value.idSector;
                }

            }

            FirebaseResponse res1 = clien.Get(@"Sector");
            Dictionary<string, Sector> data1 = JsonConvert.DeserializeObject<Dictionary<string, Sector>>(res1.Body.ToString());

            foreach (var item in data1)
            {
                 nombreSector = item.Value.nombre;
            }


              return nombreSector;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            String nomSector = obtenerNombreSector();

            if (tbPrecio.Text!=null)
            {
                FirebaseResponse res = clien.Get(@"Servicio/" + idServicio);
                Servicio resServicio = res.ResultAs<Servicio>();


                Servicio servicioModificado = new Servicio(resServicio.idServicio, resServicio.nombre, resServicio.descripcion, float.Parse(tbPrecio.Text), resServicio.duracion, resServicio.idSector);
                var res2 = clien.Update("Servicio/" + idServicio, servicioModificado);

                MessageBox.Show("El precio de  " + resServicio.nombre + " ha sido modificado con éxito");

                this.Close();
                FormPrecios formPrecios = new FormPrecios();
                formPrecios.Show();
            }
            else
            {
                MessageBox.Show("Completa el campo de precio");
            }
        }
    }
}
