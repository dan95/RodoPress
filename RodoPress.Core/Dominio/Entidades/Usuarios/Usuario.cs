using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Entidades.Usuarios
{
    public class Usuario
    {
        public virtual String Cpf { get; set; }
        public virtual String Nome { get; set; }
        public virtual String Rg { get; set; }
        public virtual String Endereco { get; set; }
        public virtual String NivelAcesso { get; set; }
        public virtual DateTime DataNascimento { get; set; }
        public virtual String Email { get; set; }
        public virtual String Login {get;set;}
        public virtual String Senha { get; set; }
    }
}
