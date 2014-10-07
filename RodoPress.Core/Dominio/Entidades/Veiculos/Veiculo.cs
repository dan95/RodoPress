using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Entidades
{
    public class Veiculo
    {
        public virtual String Placa { get; set; }
        public virtual Modelo Modelo { get; set; }
        public virtual DateTime Ano { get; set; }
        public virtual String Status { get; set; }
    }
}
