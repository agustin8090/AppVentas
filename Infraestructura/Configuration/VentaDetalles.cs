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
            builder.HasOne(vd => vd.Venta)
                .WithMany(v => v.Detalles)
                .HasForeignKey(vd => vd.IdVenta);
            builder.HasOne(vd => vd.Producto)
                .WithMany(p => p.VentaDetalles)
                .HasForeignKey(vd => vd.IdProducto);
        }
    }
}
