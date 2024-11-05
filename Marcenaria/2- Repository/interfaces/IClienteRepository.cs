using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._2__Repository.interfaces
{
    public interface IClienteRepository
    {
        void Adicionar(Cliente clientes);
        void Remover(int id);
        void Editar(Cliente clientes);
        List<Cliente> Listar();
        Cliente BuscarPorId(int id);
    }
}
