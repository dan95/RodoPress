using FluentNHibernate.Mapping;
using RodoPress.Core.Dominio.Entidades.Viagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Dados.Mapeamento.Viagens
{
    public class PassagemMapeamento:ClassMap<Passagem>
    {
        public PassagemMapeamento() 
        {
            Table("Passagem");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Descricao).Not.Nullable();

            References(x => x.Viagem).Not.Nullable().Column("IdViagem");
        }
    }
}
