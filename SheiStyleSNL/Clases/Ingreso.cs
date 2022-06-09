using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheiStyleSNL.Clases
{
   public class Ingreso
    {
        
            public Ingreso()
            {

            }

            public Ingreso(String idIngreso, DateTime fecha, float cantidad, String idCita)
            {
                this.idIngreso = idIngreso;
                this.fecha = fecha;
                this.cantidad = cantidad;
                this.idCita = idCita;                
            }

        public String idIngreso { get; set; }
        public DateTime fecha { get; set; }
        public float cantidad { get; set; }
        public String idCita { get; set; }


    }
    }
