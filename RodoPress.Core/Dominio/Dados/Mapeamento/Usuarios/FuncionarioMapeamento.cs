using FluentNHibernate.Mapping;
using RodoPress.Core.Dominio.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Dados.Mapeamento.Usuarios
{
    class FuncionarioMapeamento:ClassMap<Funcionario>
    {
        public FuncionarioMapeamento() 
        {
            Table("Funcionario");
            Id(x => x.Matricula);
            Map(x => x.Nome).Not.Nullable();
            Map(x => x.Departamento).Not.Nullable();
            Map(x => x.Cargo).Not.Nullable();
            Map(x => x.Salario).Not.Nullable().Precision(2);
            Map(x => x.Cpf).Not.Nullable();
            Map(x => x.Rg).Not.Nullable();
            Map(x => x.DataNascimento).Not.Nullable();
            Map(x => x.Endereco).Not.Nullable();

            References(x => x.Usuario).Not.Nullable().Column("idUsuario");
        }
    }
}
