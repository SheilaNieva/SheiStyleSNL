using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheiStyleSNL.Clases
{
    public class Cita
    {

        public Cita()
        {

        }

        public Cita(String idCita, String idCliente, String servicio, DateTime fecha, float duracion, float precioCita)
        {
            this.idCita = idCita;
            this.idCliente = idCliente;
            this.servicio = servicio;
            this.fecha = fecha;
            this.duracion = duracion;
            this.precioCita = precioCita;
        }


        public String idCita { get; set; }
        public String idCliente { get; set; }
        public String servicio { get; set; }
        public DateTime fecha { get; set; }
        public float  duracion { get; set; }
        public float precioCita { get; set; }
    }
}
