using FluentNHibernate.Mapping;
using RodoPress.Core.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Dados.Mapeamento.Veiculos
{
    public class MarcaMapeamento:ClassMap<Marca>
    {
        public MarcaMapeamento() 
        {
            Table("Marca");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Nome).Not.Nullable().Length(50);
        }
    }
}
