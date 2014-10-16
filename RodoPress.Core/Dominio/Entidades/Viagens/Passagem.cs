using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Entidades.Viagens
{
    public class Passagem
    {
        public virtual int Id { get; set; }
        public virtual Viagem Viagem { get; set; }
        public virtual String Descricao { get; set; }
        public virtual String Status { get; set; }
        public virtual Double Preco { get; set; }
    }
}
