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
    public partial class FormEditarCliente : Form
    {
        Cliente resCliente;
        public FormEditarCliente(Cliente resCliente)
        {
            InitializeComponent();
            this.resCliente = resCliente;
            cargar();
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

            FormListadoClientes frmListadoCliente = new FormListadoClientes();
            frmListadoCliente.Show();
        }

        private void cargar()
        {
            try
            {
                clien = new FireSharp.FirebaseClient(ifc);
                tbNombre.Text = resCliente.nombre;
                tbApellidos.Text = resCliente.apellidos;
                tbTlfn.Text = resCliente.telefono;
                tbCorreo.Text = resCliente.correo;

            }
            catch (Exception)
            {

                throw; //no internet connection
            }
        }
       
    }
}
