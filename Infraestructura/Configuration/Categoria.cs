using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;

namespace Infraestructura.Configuration
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(c => c.IdCategoria);
            builder.Property(c => c.NombreCategoria)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(c => c.Descripcion)
                .HasMaxLength(500);
            builder.Property(c => c.Estado)
                .IsRequired();
            builder.Property(c => c.FechaCreacion)
                .IsRequired();
            builder.Property(c => c.FechaCreacion)
                .IsRequired();
            // Relaciones
            builder.HasMany(c => c.Productos)
                .WithOne(p => p.Categoria)
                .HasForeignKey(p => p.IdCategoria);
        }
    }
}
