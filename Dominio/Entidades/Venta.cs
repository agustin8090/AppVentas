using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Enums;

namespace Dominio.Entidades
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public int IdUsuario { get; set; }
        public decimal Total { get; set; }
        public MetodoPago MetodoDePago { get; set; }
        public bool Estado { get; set; }   

        public Usuario Usuario { get; set; } = new Usuario();
        // una venta tiene muchos detalles de venta
        public ICollection<VentaDetalle> Detalles { get; set; } = new List<VentaDetalle>();
    }
}
