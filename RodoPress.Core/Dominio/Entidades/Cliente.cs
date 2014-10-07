using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Entidades
{
    public class Cliente
    {
        public String Cpf { get; set; }
        public String Nome { get; set; }
        public String Rg { get; set; }
        public String Endereco { get; set; }
        public String Email { get; set; }
        public String DataNascimento { get; set; }
    }
}
