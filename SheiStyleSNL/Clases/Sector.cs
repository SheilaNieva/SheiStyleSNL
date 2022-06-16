using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheiStyleSNL.Clases
{
  public class Sector
    {

        public Sector()
        {
        }


        public Sector(String idSector, String nombre)
        {
            this.idSector = idSector;
            this.nombre = nombre;
        }

        public String idSector { get; set; }
        public String nombre { get; set; }
    }
}
