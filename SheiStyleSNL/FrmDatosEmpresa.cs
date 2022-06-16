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
using System.Collections;

namespace SheiStyleSNL
{
    public partial class FrmDatosEmpresa : Form
    {
        public FrmDatosEmpresa()
        {
            InitializeComponent();
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

        private void FrmDatosEmpresa_Load(object sender, EventArgs e)
        {
            FirebaseResponse res = clien.Get(@"Empresa");
            Dictionary<string, Empresa> data = JsonConvert.DeserializeObject<Dictionary<string, Empresa>>(res.Body.ToString());

            foreach (var item in data)
            {
                tbNombre.Text = item.Value.nombre;
                tbTlfn.Text = item.Value.telefono;
                tbDireccion.Text = item.Value.direccion;
                tbCorreo.Text = item.Value.correo;
            }
            

        }
    }
}
