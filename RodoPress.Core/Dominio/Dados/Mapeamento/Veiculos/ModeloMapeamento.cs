using FluentNHibernate.Mapping;
using RodoPress.Core.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Dados.Mapeamento.Veiculos
{
    public class ModeloMapeamento:ClassMap<Modelo>
    {
        public ModeloMapeamento() 
        {
            Table("Modelo");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Nome).Not.Nullable().Length(60);
            Map(x => x.Motor).Not.Nullable().Length(30);
            Map(x => x.NumeroAssentos).Not.Nullable();
            Map(x => x.Largura).Not.Nullable();
            Map(x => x.Comprimento).Not.Nullable();

            References(x => x.Marca).Not.Nullable().Column("IdMarca");
        }
    }
}
