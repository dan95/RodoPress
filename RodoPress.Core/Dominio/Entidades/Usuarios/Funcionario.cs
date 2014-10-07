using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Entidades.Usuarios
{
    public class Funcionario:Usuario
    {
        public virtual int Matricula { get; set; }
        public virtual String Cargo { get; set; }
        public virtual String Departamento { get; set; }
        public virtual Double Salario { get; set; }
    }
}
