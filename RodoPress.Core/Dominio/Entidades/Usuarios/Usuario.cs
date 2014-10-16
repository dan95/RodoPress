using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Entidades.Usuarios
{
    public class Usuario
    {
        public virtual int Id { get; set; }
        public virtual String NivelAcesso { get; set; }
        public virtual String Tipo { get; set; }
        public virtual String Status { get; set; }
        public virtual String Login { get; set; }
        public virtual String Senha { get; set; }
        public virtual String Email { get; set; }
    }
}