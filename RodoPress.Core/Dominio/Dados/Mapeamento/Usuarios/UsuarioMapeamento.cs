using FluentNHibernate.Mapping;
using RodoPress.Core.Dominio.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Dados.Mapeamento.Usuarios
{
    public class UsuarioMapeamento : ClassMap<Usuario>
    {
        public UsuarioMapeamento()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Email).Not.Nullable();
            Map(x => x.Login).Not.Nullable();
            Map(x => x.Senha).Not.Nullable();
            Map(x => x.NivelAcesso).Not.Nullable();
        }
    }
}
