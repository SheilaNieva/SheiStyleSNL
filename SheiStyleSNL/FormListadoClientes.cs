﻿using System;
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

namespace SheiStyleSNL
{
    public partial class FormListadoClientes : Form
    {
        public FormListadoClientes()
        {
            InitializeComponent();
            cargar();
            cargarDatagrid();
        }


        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "6vyUU5qV0nzcwGXgtnzkyPvZDBe8ykvBXH6UV53I",
            BasePath = "https://sheistyle-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient clien;


        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal frmPrincipal = new FormPrincipal();
            frmPrincipal.Show();
        }

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

        private void cargarDatagrid()
        {
            FirebaseResponse res = clien.Get(@"Cliente");
            Dictionary<string, Cliente> data = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(res.Body.ToString());
            rellenarListado(data);
        }

        private void rellenarListado(Dictionary<string, Cliente> data)
        {
            listVClientes.Clear();
            listVClientes.Columns.Clear();

            listVClientes.Columns.Add("Nombre",150);
            listVClientes.Columns.Add("Apellidos",150);
            listVClientes.Columns.Add("Teléfono",150);
            listVClientes.Columns.Add("Correo",150);
            listVClientes.Columns.Add("IDCliente", 0);
            


            foreach (var item in data)
            {
                String[] row = {item.Value.nombre, item.Value.apellidos, item.Value.telefono, item.Value.correo, item.Value.idCliente};
                 var itemListView = new ListViewItem(row);
                listVClientes.Items.Add(itemListView);
             
            }

           
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNuevoCliente frmNuevoCliente = new FormNuevoCliente();
            frmNuevoCliente.Show();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            seleccionarCliente();
        }


        private void listVClientes_DoubleClick(object sender, EventArgs e)
        {
            seleccionarCliente();
        }

        private void seleccionarCliente()
        {
            int fila = listVClientes.FocusedItem.Index; //Obtenemos la fila que pulsamos
            String idCliente = listVClientes.Items[fila].SubItems[4].Text; //Obtenemos el idCliente de la fila que hemos seleccionado

            FirebaseResponse res = clien.Get(@"Cliente/" + idCliente);
            Cliente resCliente = res.ResultAs<Cliente>();
            
             this.Hide();
             FormEditarCliente frmEditarCliente = new FormEditarCliente(resCliente);
             frmEditarCliente.Show();
        }
    }
}
