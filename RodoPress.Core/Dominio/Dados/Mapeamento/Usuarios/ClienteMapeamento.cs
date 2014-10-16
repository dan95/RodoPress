using FluentNHibernate.Mapping;
using RodoPress.Core.Dominio.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Dados.Mapeamento.Usuarios
{
    public class ClienteMapeamento:ClassMap<Cliente>
    {
        public ClienteMapeamento() 
        {
            Table("Cliente");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Nome).Not.Nullable().Length(50);
            Map(x => x.Cpf).Not.Nullable().Length(14);
            Map(x => x.Rg).Not.Nullable().Length(12);
            Map(x => x.DataNascimento).Not.Nullable();
            Map(x => x.Endereco).Not.Nullable().Length(500);

            References(x => x.Usuario).Not.Nullable().Column("idUsuario");
        }
    }
}
