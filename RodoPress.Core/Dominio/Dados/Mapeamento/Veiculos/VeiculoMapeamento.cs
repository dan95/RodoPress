using FluentNHibernate.Mapping;
using RodoPress.Core.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Dados.Mapeamento.Veiculos
{
    public class VeiculoMapeamento:ClassMap<Veiculo>
    {
        public VeiculoMapeamento() 
        {
            Table("Veiculo");
            Id(x => x.Placa).Length(8);
            Map(x => x.Ano).Not.Nullable();
            Map(x => x.Status).Not.Nullable();

            References(x => x.Modelo).Not.Nullable().Column("IdModelo");
        }
    }
}
