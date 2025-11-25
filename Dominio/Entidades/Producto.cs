namespace Dominio.Entidades
{
    public class Producto
    {
        public int IdProducto { get; set; } 
        public string NombreProducto { get; set; } 
        public int StockActual { get; set; } 
        public decimal PrecioUnitario { get; set; } 
        public int IdCategoria { get; set; } 
        public bool Estado { get; set; } 
        public DateTime FechaCreacion { get; set; } 
        public DateTime FechaActualizacion { get; set; } 

        public Categoria Categoria { get; set; } = new Categoria();
        public List<VentaDetalle> VentaDetalles { get; set; } = new List<VentaDetalle>();

    }
}
