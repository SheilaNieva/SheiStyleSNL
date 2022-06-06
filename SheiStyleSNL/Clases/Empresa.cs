using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheiStyleSNL.Clases
{
    public class Empresa
    {
        public Empresa()
        {

        }

        public Empresa(String idEmpresa, String nombre, String direccion, String telefono, String correo)
        {
            this.idEmpresa = idEmpresa;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
        }


        public String idEmpresa { get; set; }
        public String nombre { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        public String correo { get; set; }

    }
}
