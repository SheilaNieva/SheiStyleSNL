using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheiStyleSNL.Clases
{
    public class Cliente
    {

        public Cliente() { }

        public Cliente(String idCliente, String nombre, String apellidos, String telefono, String correo, String idEmpresa)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.correo = correo;
            this.idEmpresa = idEmpresa;


            //Inicializar campos
            //this.empresa = "SheiStyle";
            this.citasAcumuladas = 1;
        }

        public Cliente(String idCliente, String nombre, String apellidos, String telefono, String correo, String idEmpresa, int citasAcumuladas)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.correo = correo;
            this.idEmpresa = idEmpresa;


            //Inicializar campos
            //this.empresa = "SheiStyle";
            this.citasAcumuladas = citasAcumuladas;
        }

        public String idCliente { get; set; }
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public String telefono { get; set; }
        public String correo { get; set; }
        public int citasAcumuladas { get; set; }
        public String idEmpresa { get; set; }


    }
}
