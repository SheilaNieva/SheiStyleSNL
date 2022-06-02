using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheiStyleSNL.Clases
{
    public class Servicio
    {
        public Servicio()
        {

        }
        public Servicio(String idServicio, String nombre, String descripcion, float precio, Sector sector)
        {
            this.idServicio = idServicio;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.sector = sector;
        }

        public String idServicio { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }
        public float precio { get; set; }
        public Sector sector { get; set; }
    }
}
