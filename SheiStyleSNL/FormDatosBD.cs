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
    public partial class FormDatosBD : Form
    {
        ArrayList array = new ArrayList();
        public FormDatosBD()
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

        private void button1_Click(object sender, EventArgs e)
        {

            Servicio servicio = new Servicio();

            Guid UUID = Guid.NewGuid();
            servicio.idServicio = UUID.ToString();
            String idServicio1 = servicio.idServicio;
            servicio.nombre = tbNombre.Text;
            servicio.descripcion = tbdesc.Text;
            servicio.precio = float.Parse(tbprecio.Text);
            servicio.duracion = float.Parse(tbduracion.Text);



            FirebaseResponse res = clien.Get(@"Sector");
            Dictionary<string, Sector> data = JsonConvert.DeserializeObject<Dictionary<string, Sector>>(res.Body.ToString());

            foreach (var item in data)
            {
                array.Add(item.Value.idSector);
            }
            servicio.idSector = array[1].ToString();
            
            SetResponse resServicio = clien.Set(@"Servicio/" + idServicio1, servicio);



            // Sector sector = new Sector(idSector, nombre);
            // SetResponse res = clien.Set(@"Sector/" + idSector, sector);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();

            Guid UUID = Guid.NewGuid();
            empresa.idEmpresa = UUID.ToString();
            empresa.nombre = tbNombreE.Text;
            empresa.direccion = tbDireccionE.Text;
            empresa.telefono = tbTelefonoE.Text;
            empresa.correo = tbCorreoE.Text;



            SetResponse resEmpresa = clien.Set(@"Empresa/" + empresa.idEmpresa, empresa);
        }
    }
}
