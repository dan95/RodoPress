using RodoPress.Core.Dominio.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodoPress.Core.Dominio.Dados.Contrato
{
    public interface IClienteRepository
    {
        void Novo(Cliente cliente);
        void Editar(Cliente cliente);
        void Excluir(Cliente cliente);
        Cliente Buscar(int id);
        Cliente Buscar(string cpf);
    }
}