using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Entidades
{
    public class Modelo
    {
        public virtual int Id { get; set; }
        public virtual Marca Marca { get; set; }
        public virtual String Nome { get; set; }
        public virtual int NumeroAssentos { get; set; }
        public virtual Double Comprimento { get; set; }
        public virtual Double Largura { get; set; }
        public virtual String Motor { get; set; }
        public virtual String TipoCombustivel { get; set; }
    }
}
