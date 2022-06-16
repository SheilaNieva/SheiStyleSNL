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
    public partial class FormPrecios : Form
    {
        ArrayList array = new ArrayList();
        public FormPrecios()
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


        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal frmPrincipal = new FormPrincipal();
            frmPrincipal.Show();
        }

        private void FormPrecios_Load(object sender, EventArgs e)
        {

            crearTablas();

            FirebaseResponse res = clien.Get(@"Sector");
            Dictionary<string, Sector> data = JsonConvert.DeserializeObject<Dictionary<string, Sector>>(res.Body.ToString());

            foreach (var item in data)
            {
                array.Add(item.Value.idSector);
            }
           

            FirebaseResponse res1 = clien.Get(@"Servicio");
            Dictionary<string, Servicio> data1 = JsonConvert.DeserializeObject<Dictionary<string, Servicio>>(res1.Body.ToString());

            foreach (var item in data1)
            {
                if (array[0].ToString() == item.Value.idSector) //sector CERA

                {
                    dgvCera.Rows.Add(item.Value.nombre, item.Value.precio, item.Value.idServicio);
                }

                if (array[1].ToString() == item.Value.idSector) //sector UÑAS

                {
                    dgvUnas.Rows.Add(item.Value.nombre, item.Value.precio, item.Value.idServicio);
                }

                if (array[2].ToString() == item.Value.idSector) //sector BARBERIA

                {
                    dgvBarberia.Rows.Add(item.Value.nombre, item.Value.precio, item.Value.idServicio);
                }

                if (array[3].ToString() == item.Value.idSector) //sector PELUQUERIA

                {
                    dgvPeluqueria.Rows.Add(item.Value.nombre, item.Value.precio, item.Value.idServicio);
                }

                if (array[4].ToString() == item.Value.idSector) //sector LASER

                {
                    dgvLaser.Rows.Add(item.Value.nombre, item.Value.precio, item.Value.idServicio);
                }
            
            }
            limpiarSeleccion();
           
        }

        private void crearTablas()
        {

            dgvPeluqueria.Columns.Clear();
            dgvPeluqueria.Columns.Add("Servicio", "Servicio");
            dgvPeluqueria.Columns.Add("Precio", "Precio");
            dgvPeluqueria.Columns.Add("IdServicio", "IdServicio");
            dgvPeluqueria.Columns["IdServicio"].Visible = false;



            dgvUnas.Columns.Clear();
            dgvUnas.Columns.Add("Servicio", "Servicio");
            dgvUnas.Columns.Add("Precio", "Precio");
            dgvUnas.Columns.Add("IdServicio", "IdServicio");
            dgvUnas.Columns["IdServicio"].Visible = false;

            dgvBarberia.Columns.Clear();
            dgvBarberia.Columns.Add("Servicio", "Servicio");
            dgvBarberia.Columns.Add("Precio", "Precio");
            dgvBarberia.Columns.Add("IdServicio", "IdServicio");
            dgvBarberia.Columns["IdServicio"].Visible = false;

            dgvCera.Columns.Clear();
            dgvCera.Columns.Add("Servicio", "Servicio");
            dgvCera.Columns.Add("Precio", "Precio");
            dgvCera.Columns.Add("IdServicio", "IdServicio");
            dgvCera.Columns["IdServicio"].Visible = false;

            dgvLaser.Columns.Clear();
            dgvLaser.Columns.Add("Servicio", "Servicio");
            dgvLaser.Columns.Add("Precio", "Precio");
            dgvLaser.Columns.Add("IdServicio", "IdServicio");
            dgvLaser.Columns["IdServicio"].Visible = false;
        }

        private void limpiarSeleccion()
        {
            dgvPeluqueria.Rows[0].Selected = false;
            dgvUnas.Rows[0].Selected = false;
            dgvLaser.Rows[0].Selected = false;
            dgvCera.Rows[0].Selected = false;
            dgvBarberia.Rows[0].Selected = false;
        }

        private void btnModificarPrecio_Click(object sender, EventArgs e)
        {
         if(dgvPeluqueria.SelectedRows.Count>0)
            {
                seleccionItem(dgvPeluqueria);
            } else if (dgvCera.SelectedRows.Count > 0)
            {
                seleccionItem(dgvCera);
            }
            else if (dgvBarberia.SelectedRows.Count > 0)
            {
                seleccionItem(dgvBarberia);
            }
            else if (dgvLaser.SelectedRows.Count > 0)
            {
                seleccionItem(dgvLaser);
            }
            else if (dgvUnas.SelectedRows.Count > 0)
            {
                seleccionItem(dgvUnas);
            }
            else if (dgvCera.SelectedRows.Count > 0)
            {
                seleccionItem(dgvCera);
            }
            else
            {
                MessageBox.Show("Elija un servicio para modificar su precio");
            }
        }

        private void seleccionItem(DataGridView dgv)
        {
            int index = dgv.CurrentCell.RowIndex;
            String idServicio = dgv.Rows[index].Cells[2].Value.ToString();
            //MessageBox.Show(idServicio);
            this.Hide();
            FormModificarPrecio frmModificarPrecio = new FormModificarPrecio(idServicio);
            frmModificarPrecio.Show();
            limpiarSeleccion();
        }

        private void dgvPeluqueria_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionItem(dgvPeluqueria);
        }

        private void dgvUnas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionItem(dgvUnas);
        }

        private void dgvBarberia_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionItem(dgvBarberia);
        }

        private void dgvCera_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionItem(dgvCera);
        }

        private void dgvLaser_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionItem(dgvLaser);
        }

        private void dgvPeluqueria_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            seleccionItem(dgvPeluqueria);
        }
    }
}
