using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;

namespace Infraestructura.Configuration
{
    public class ProductoConfiguration: IEntityTypeConfiguration<Producto>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Producto> builder)
        {
            builder.HasKey(p => p.IdProducto);
            builder.Property(p => p.NombreProducto)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(p => p.StockActual)
                .IsRequired();
            builder.Property(p => p.PrecioUnitario)
                .IsRequired()
                .HasColumnType("decimal(18,2)");
            builder.Property(p => p.IdCategoria)
                .IsRequired();
            builder.Property(p => p.Estado)
                .IsRequired();
            builder.Property(p => p.FechaCreacion)
                .IsRequired();
            builder.Property(p => p.FechaActualizacion)
                .IsRequired();
            // Relaciones
            builder.HasOne(p => p.Categoria)
                .WithMany(c => c.Productos)
                .HasForeignKey(p => p.IdCategoria);
            builder.HasMany(p => p.VentaDetalles)
                .WithOne(vd => vd.Producto)
                .HasForeignKey(vd => vd.IdProducto);
        }
    }
}
