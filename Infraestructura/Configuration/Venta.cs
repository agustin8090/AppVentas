using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Configuration
{
    public class VentaConfiguration : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.HasKey(v => v.IdVenta);
            builder.Property(v => v.FechaVenta)
                .IsRequired();
            builder.Property(v => v.Total)
                .IsRequired()
                .HasColumnType("decimal(18,2)");
            builder.Property(v => v.Estado)
                .IsRequired();
            // Relaciones
            builder.HasMany(v => v.Detalles)
                .WithOne(dv => dv.Venta)
                .HasForeignKey(dv => dv.IdVenta);
            builder.HasOne(v => v.Usuario)
                .WithMany(u => u.Ventas)
                .HasForeignKey(v => v.IdUsuario);
        }
    }
}
