using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Usuario
    {

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public RolUsuario Rol { get; set; }

        public bool Estado { get; set; } 
        public DateTime FechaCreacion { get; set; } 

        public ICollection<Venta> Ventas { get; set; } = new List<Venta>();
        public ICollection<Auditoria> Auditorias { get; set; } = new List<Auditoria>();
    }
}
