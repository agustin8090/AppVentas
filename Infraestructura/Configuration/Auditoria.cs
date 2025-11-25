using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;

namespace Infraestructura.Configuration
{
    public class AuditoriaConfiguration : IEntityTypeConfiguration<Auditoria>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auditoria> builder)
        {
            builder.HasKey(a => a.IdAuditoria);
            builder.Property(a => a.EntidadAfectada)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(a => a.TipoAccion)
                .IsRequired()
                .HasMaxLength(50);
                
            builder.Property(a => a.FechaAccion)
                .IsRequired();
            builder.Property(a => a.IdRegistroAfectado)
                .IsRequired();
            builder.Property(a => a.ValorAnterior)
                .HasMaxLength(500);
            builder.Property(a => a.NuevoValor)
                .HasMaxLength(500);
            builder.Property(a => a.IdUsuario)
                .IsRequired();
            // RELACIONES
            builder.HasOne(a => a.Usuario)
                .WithMany(u => u.Auditorias)
                .HasForeignKey(a => a.IdUsuario);

        }
    
    }
}
