using FluentNHibernate.Mapping;
using RodoPress.Core.Dominio.Entidades.Viagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Dados.Mapeamento.Viagens
{
    public class ViagemMapeamento:ClassMap<Viagem>
    {
        public ViagemMapeamento() 
        {
            Table("Viagem");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Origem).Not.Nullable();
            Map(x => x.Destino).Not.Nullable();
            Map(x => x.Status).Not.Nullable();
            Map(x => x.DataPrevista).Not.Nullable();
            Map(x => x.PoltronasRestantes).Not.Nullable();

            References(x => x.Veiculo).Not.Nullable().Column("IdVeiculo");
            References(x => x.Motorista).Not.Nullable().Column("IdMotorista");
        }
    }
}
