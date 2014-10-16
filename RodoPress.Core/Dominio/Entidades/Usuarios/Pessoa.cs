using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Entidades.Usuarios
{
    public class Pessoa
    {
        public virtual String Cpf { get; set; }
        public virtual String Nome { get; set; }
        public virtual String Rg { get; set; }
        public virtual String Endereco { get; set; }
        public virtual DateTime DataNascimento { get; set; }
    }
}
