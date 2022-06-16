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

        public Pedido(String idPedido, String descripcion, float importe, DateTime fecha, String empresa)
        {
            this.idPedido = idPedido;
            this.descripcion = descripcion;
            this.importe = importe;
            this.fecha = fecha;
            this.empresa = empresa;
        }

        public String idPedido { get; set; }
        public String descripcion { get; set; }
        public float importe { get; set; }
        public DateTime fecha { get; set; }
        public String empresa { get; set; }
    }
}
