using RodoPress.Core.Dominio.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Entidades.Viagens
{
    public class Reserva
    {
        public virtual int Id { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Passagem Passagem { get; set; }
        public virtual DateTime DataReserva { get; set; }
        public virtual String Status { get; set; }
    }
}
