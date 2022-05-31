using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheiStyleSNL.Clases
{
    public class Pedido
    {
        public Pedido()
        {

        }

        public Pedido(String idPedido, String descripcion, float importe, String fecha)
        {
            this.idPedido = idPedido;
            this.descripcion = descripcion;
            this.importe = importe;
            this.fecha = fecha;
        }

        public String idPedido { get; set; }
        public String descripcion { get; set; }
        public float importe { get; set; }
        public String fecha { get; set; }
    }
}
