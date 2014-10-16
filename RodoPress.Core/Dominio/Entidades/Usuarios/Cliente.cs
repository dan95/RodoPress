using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Entidades.Usuarios
{
    public class Cliente: Pessoa
    {
        public virtual int Id { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
