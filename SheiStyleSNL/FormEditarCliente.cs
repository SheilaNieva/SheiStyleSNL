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

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            bool correcto;

            String idCliente = resCliente.idCliente;
            String nombre = tbNombre.Text;
            String apellidos = tbApellidos.Text;
            String telefono = tbTlfn.Text;
            String correo = tbCorreo.Text;

            correcto = comprobarDatosCliente(nombre, apellidos, telefono, correo);

            if (correcto)
            {

               Cliente clienteModificado = new Cliente(idCliente, nombre, apellidos, telefono, correo);
               var res = clien.Update("Cliente/" + idCliente, clienteModificado);

                MessageBox.Show("Cliente " + nombre + " se ha modificado con éxito");

                this.Close();
                FormListadoClientes frmListadoCliente = new FormListadoClientes();
                frmListadoCliente.Show();
            }
        }

        private bool comprobarDatosCliente(string nombre, string apellidos, string telefono, string correo)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellidos) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("Debes rellenar todos los campos");
                return false;
            }
            else
            {
                if (!tbTlfn.MaskCompleted) //comprueba que el tlfn tenga 9 digitos
                {
                    MessageBox.Show("El teléfono debe contener 9 dígitos");
                    return false;
                }
                else if (!correoValido(correo))
                {
                    MessageBox.Show("Formato del correo erróneo");
                    return false;
                }
                else
                {
                    return true;
                }

            }

        }

        private bool correoValido(string correo)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, sFormato))
            {
                if (Regex.Replace(correo, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
