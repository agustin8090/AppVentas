using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Auditoria
    {

    public int IdAuditoria { get; set; }
    public int IdUsuario { get; set; }
    public DateTime FechaAccion { get; set; }
    public string EntidadAfectada { get; set; }
    public string TipoAccion { get; set; }
    public int IdRegistroAfectado { get; set; }
    public string ValorAnterior { get; set; }
    public string NuevoValor { get; set; }
       
        public Usuario Usuario { get; set; } = new Usuario();

    }
}
