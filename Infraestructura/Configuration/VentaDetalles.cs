using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;

namespace Infraestructura.Configuration
{
    public class VentaDetallesConfiguration : IEntityTypeConfiguration<VentaDetalle>
    { 
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VentaDetalle> builder)
        {
            builder.HasKey(vd => vd.IdVentaDetalle);
            builder.Property(vd => vd.IdVenta)
                .IsRequired();
            builder.Property(vd => vd.IdProducto)
                .IsRequired();
            builder.Property(vd => vd.Cantidad)
                .IsRequired();
            builder.Property(vd => vd.PrecioUnitario)
                .IsRequired()
                .HasColumnType("decimal(18,2)");
            builder.Property(vd => vd.SubTotal)
                .IsRequired()
                .HasColumnType("decimal(18,2)");
            // Relaciones
            //Ventadetalle tiene una venta
            builder.HasOne(vd => vd.Venta)
                //venta tiene muchos detalles
                .WithMany(v => v.Detalles)
                //la foreign key esta en ventadetalle
                .HasForeignKey(vd => vd.IdVenta);

            //Ventadetalle tiene un producto
            builder.HasOne(vd => vd.Producto)
                //producto tiene muchos ventadetalles
                .WithMany(p => p.VentaDetalles)
                //la foreign key esta en ventadetalle
                .HasForeignKey(vd => vd.IdProducto);
        }
    }
}
