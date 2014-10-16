using FluentNHibernate.Mapping;
using RodoPress.Core.Dominio.Entidades.Viagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Dados.Mapeamento.Viagens
{
    public class ReservaMapeamento:ClassMap<Reserva>
    {
        public ReservaMapeamento() 
        {
            Table("Reserva");
            Id(x => x.Id);
            Map(x => x.DataReserva).Not.Nullable();
            Map(x => x.Status).Not.Nullable();

            References(x => x.Cliente).Not.Nullable().Column("IdCliente");
            References(x => x.Passagem).Not.Nullable().Column("IdPassagem");
        }
    }
}
