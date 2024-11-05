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
    public class CarrinhoService : ICarrinhoService
    {
        private readonly ICarrinhoRepository repository;
        public CarrinhoService(ICarrinhoRepository _repository)
        {
            repository = _repository;
        }
        public void Adicionar(Carrinho carrinho)
        {
            repository.Adicionar(carrinho);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Carrinho> Listar()
        {
            return repository.Listar();
        }

        public List<Readcarrinho> ListarCarrinhoDoUsuario(int clienteId)
        {
            return repository.ListarCarrinhoDoUsuario(clienteId);
        }
        public Carrinho BuscarTimePorId(int id)
        {
            return repository.BuscarPorId(id);
        }
        public void Editar(Carrinho editPessoa)
        {
            repository.Editar(editPessoa);
        }
    }
}
