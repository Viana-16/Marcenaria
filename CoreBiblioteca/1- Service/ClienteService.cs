using Marcenaria._1__Service.interfaces;
using Marcenaria._2__Repository;
using Marcenaria._2__Repository.interfaces;
using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._1__Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;
        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }
        public void Adicionar(Cliente clientes)
        {
            _repository.Adicionar(clientes);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public List<Cliente> Listar()
        {
            return _repository.Listar();
        }
        public Cliente BuscarPorId(int id)
        {
           return _repository.BuscarPorId(id);
        }
        public void Editar(Cliente editClientes)
        {
            _repository.Editar(editClientes);
        }
       
    }
}
