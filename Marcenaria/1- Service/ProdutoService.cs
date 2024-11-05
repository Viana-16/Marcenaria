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
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;
        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }
        public void Adicionar(Produtos produto)
        {
            _repository.Adicionar(produto);
        }

        public void Remover(int id)
        {
           _repository.Remover(id);
        }

        public List<Produtos> Listar()
        {
            return _repository.Listar();
        }
        public Produtos BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }
        public void Editar( Produtos editProduto)
        {
            _repository.Editar( editProduto);
        }

    }
}
