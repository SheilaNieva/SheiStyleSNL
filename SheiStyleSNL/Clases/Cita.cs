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

        public Cita(String idCita, String nombreCliente, String servicio, String fecha, float precioCita)
        {
            this.idCita = idCita;
            this.nombreCliente = nombreCliente;
            this.servicio = servicio;
            this.fecha = idCita;
            this.duracion = 1;
            this.precioCita = precioCita;
        }


        public String idCita { get; set; }
        public String nombreCliente { get; set; }
        public String servicio { get; set; }
        public String fecha { get; set; }
        public int  duracion { get; set; }
        public float precioCita { get; set; }
    }
}
