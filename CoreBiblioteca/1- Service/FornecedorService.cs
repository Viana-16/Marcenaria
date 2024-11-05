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
    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository _repository;
        public FornecedorService(IFornecedorRepository repository)
        {
            _repository = repository;
        }
        public void Adicionar(Fornecedor fornecedor)
        {
            _repository.Adicionar(fornecedor);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public List<Fornecedor> Listar()
        {
            return _repository.Listar();
        }
        public Fornecedor BuscarPorId(int id)
        {
           return _repository.BuscarPorId(id);
        }
        public void Editar(Fornecedor editFornecedor)
        {
            _repository.Editar(editFornecedor);
        }

    }
}

