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
    public partial class FormListadoClientes : Form
    {
        public FormListadoClientes()
        {
            InitializeComponent();
            cargar();
            cargarListado();
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

        private void cargarListado()
        {
            FirebaseResponse res = clien.Get(@"Cliente");
            Dictionary<string, Cliente> data = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(res.Body.ToString());
            rellenarListado(data);
        }

        private void rellenarListado(Dictionary<string, Cliente> data)
        {
            dibujarColumnasLista();
           

            foreach (var item in data)
            {
                //En un array de String introducimos los datos de cada cliente
                String[] row = {item.Value.nombre, item.Value.apellidos, item.Value.telefono, item.Value.correo, item.Value.idCliente};
                //Introducimos los items (clientes) en el listado
                var itemListView = new ListViewItem(row);
                listVClientes.Items.Add(itemListView);
            }
        }

        private void dibujarColumnasLista()
        {
            listVClientes.Clear();
            listVClientes.Columns.Clear();

            listVClientes.Columns.Add("Nombre", 150);
            listVClientes.Columns.Add("Apellidos", 150);
            listVClientes.Columns.Add("Teléfono", 150);
            listVClientes.Columns.Add("Correo", 150);
            listVClientes.Columns.Add("IDCliente", 0);
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNuevoCliente frmNuevoCliente = new FormNuevoCliente();
            frmNuevoCliente.Show();
        }


        //Metodo que nos permite editar un cliente
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (comprobarClienteSeleccionado())
            {
                clienteSeleccionado();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un cliente");
            }
        }


        //Metodo que comprueba si hay algun cliente seleccionado
        private bool comprobarClienteSeleccionado()
        {
            if (listVClientes.SelectedItems.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Si hacemos dobleclick en un cliente, abrimos la ventana editar y cargamos sus datos
        private void listVClientes_DoubleClick(object sender, EventArgs e)
        {
            clienteSeleccionado();
        }


        //Obtenemos el cliente que hemos seleccionado y se lo pasamos al formulario editar
        private void clienteSeleccionado()
        {
            Cliente resCliente = recuperarDatosClienteSeleccionado();
            
             this.Hide();
             FormEditarCliente frmEditarCliente = new FormEditarCliente(resCliente);
             frmEditarCliente.Show();
        }

        //Recuperamos los datos del cliente que hemos seleccionado
        private Cliente recuperarDatosClienteSeleccionado()
        {
            //Obtenemos la fila que pulsamos
            int fila = listVClientes.FocusedItem.Index;
            //Obtenemos el idCliente de la fila que hemos seleccionado
            String idCliente = listVClientes.Items[fila].SubItems[4].Text;
            
            //Obtenemos el cliente que tenfa ese id y lo devolvemos
            FirebaseResponse res = clien.Get(@"Cliente/" + idCliente);
            Cliente resCliente = res.ResultAs<Cliente>();
            return resCliente;
        }


        //comprueba que hay un cliente seleccionado y lo elimina
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (comprobarClienteSeleccionado())
            {
                Cliente resCliente = recuperarDatosClienteSeleccionado();
                var eliminar = clien.Delete("Cliente/" + resCliente.idCliente);
                MessageBox.Show("Cliente " + resCliente.nombre + " se ha eliminado con éxito");
                cargarListado();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un cliente");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String nombreBuscado = tbFiltroNombre.Text;
            bool encontrado = false;

            dibujarColumnasLista();

            FirebaseResponse res = clien.Get(@"Cliente");
            Dictionary<string, Cliente> data = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(res.Body.ToString());
            foreach (var item in data)
            {
                if (item.Value.nombre.Contains(nombreBuscado))
                {
                    //En un array de String introducimos los datos de cada cliente
                    String[] row = { item.Value.nombre, item.Value.apellidos, item.Value.telefono, item.Value.correo, item.Value.idCliente };
                    //Introducimos los items (clientes) en el listado
                    var itemListView = new ListViewItem(row);
                    listVClientes.Items.Add(itemListView);
                    encontrado = true;
                }

            }
            if (!encontrado)
            {
                MessageBox.Show("No se han encontrado clientes con ese nombre");
            }

        }

        private void tbFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            String nombreBuscado = tbFiltroNombre.Text;

            dibujarColumnasLista();

            FirebaseResponse res = clien.Get(@"Cliente");
            Dictionary<string, Cliente> data = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(res.Body.ToString());
            foreach (var item in data)
            {

                if (item.Value.nombre.Contains(nombreBuscado))
                {
                    //En un array de String introducimos los datos de cada cliente
                    String[] row = { item.Value.nombre, item.Value.apellidos, item.Value.telefono, item.Value.correo, item.Value.idCliente };
                    //Introducimos los items (clientes) en el listado
                    var itemListView = new ListViewItem(row);
                    listVClientes.Items.Add(itemListView);
                }

            }
        }
    }
}
