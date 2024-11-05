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
    public class CompraService : ICompraService
    {
        private readonly ICompraRepository _repository;
        public CompraService(ICompraRepository repository)
        {
            _repository = repository;
        }
        public void Adicionar(Compra compra)
        {
            _repository.Adicionar(compra);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public List<Compra> Listar()
        {
            return _repository.Listar();
        }
        public Compra BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }
        public void Editar(Compra editCompra)
        {
            _repository.Editar(editCompra);
        }

    }
}
