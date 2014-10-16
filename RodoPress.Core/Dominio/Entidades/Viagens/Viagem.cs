using RodoPress.Core.Dominio.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Entidades.Viagens
{
    public class Viagem
    {
        public virtual int Id { get; set; }
        public virtual String Origem { get; set; }
        public virtual String Destino { get; set; }
        public virtual DateTime DataPrevista { get; set; }
        public virtual String Status { get; set; }
        public virtual Veiculo Veiculo { get; set; }
        public virtual Funcionario Motorista { get; set; }
        public virtual int PoltronasRestantes { get; set; }
    }
}
