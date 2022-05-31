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

namespace SheiStyleSNL
{
    public partial class FormNuevoCliente : Form
    {
        public FormNuevoCliente()
        {
            InitializeComponent();
            cargar();
        }


        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormListadoClientes frmListadoCliente = new FormListadoClientes();
            frmListadoCliente.Show();
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

       

        private bool comprobarDatosCliente(string nombre, string apellidos, string telefono, string correo)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellidos) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(correo)) {
                MessageBox.Show("Debes rellenar todos los campos");
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnAnadirCliente_Click(object sender, EventArgs e)
        {
            bool correcto;
            Guid UUID = Guid.NewGuid();
            String idCliente = UUID.ToString();
            String nombre = tbNombre.Text;
            String apellidos = tbApellidos.Text;
            String telefono = tbTlfn.Text;
            String correo = tbCorreo.Text;

            correcto = comprobarDatosCliente(nombre, apellidos, telefono, correo);

            if (correcto)
            {

                Cliente cliente = new Cliente(idCliente, nombre, apellidos, telefono, correo);
                SetResponse res = clien.Set(@"Cliente/" + idCliente, cliente);

                MessageBox.Show("Cliente " + nombre + " añadido con éxito");

                tbNombre.Text = "";
                tbApellidos.Text = "";
                tbCorreo.Text = "";
                tbTlfn.Text = "";
            }
        }
    }
}
