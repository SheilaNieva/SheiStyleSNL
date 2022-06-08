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
    public partial class FormListadoCitasCliente : Form
    {
        Cliente c;
        public FormListadoCitasCliente(Cliente c)
        {
            InitializeComponent();
            this.c = c;
            cargar();
            cargarListado();
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


        private void cargarListado()
        {
            FirebaseResponse res = clien.Get(@"Cita");
            Dictionary<string, Cita> data = JsonConvert.DeserializeObject<Dictionary<string, Cita>>(res.Body.ToString());
            rellenarListado(data);
        }

        private void rellenarListado(Dictionary<string, Cita> data)
        {
            
                dibujarColumnasLista();

                foreach (var item in data)
                {
                    if (item.Value.idCliente == c.idCliente)
                    {
                        //En un array de String introducimos los datos de cada cliente
                        String[] row = { item.Value.fecha.ToShortDateString(), item.Value.fecha.ToShortTimeString(), item.Value.servicio, item.Value.precioCita.ToString() };
                        //Introducimos los items (clientes) en el listado
                        var itemListView = new ListViewItem(row);
                        listCitaClientes.Items.Add(itemListView);
                    }
                }

        }

        private void dibujarColumnasLista()
        {
            listCitaClientes.Clear();
            listCitaClientes.Columns.Clear();

            listCitaClientes.Columns.Add("Fecha", 150);
            listCitaClientes.Columns.Add("Hora", 150);
            listCitaClientes.Columns.Add("Servicios", 150);
            listCitaClientes.Columns.Add("Precio", 150);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            FormListadoClientes formListadoClientes = new FormListadoClientes();
            formListadoClientes.Show();
        }
    }
}
