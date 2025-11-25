using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Builders;  

namespace Infraestructura.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.IdUsuario);
            builder.Property(u => u.Nombre)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(u => u.Apellido)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(u => u.PasswordHash)
                .IsRequired();
            builder.Property(u => u.PasswordSalt)
                .IsRequired();
            builder.Property(u => u.Rol)
                .IsRequired();
            builder.Property(u => u.Estado)
                .IsRequired();
            builder.Property(u => u.FechaCreacion)
                .IsRequired();
            // Relaciones
            builder.HasMany(u => u.Ventas)
                .WithOne(v => v.Usuario)
                .HasForeignKey(v => v.IdUsuario);
            builder.HasMany(u => u.Auditorias)
                .WithOne(a => a.Usuario)
                .HasForeignKey(a => a.IdUsuario);
        }
    }
}
