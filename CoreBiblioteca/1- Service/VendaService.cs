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
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _repository;
        public VendaService(IVendaRepository repository)
        {
            _repository = repository;
        }
        public void Adicionar(Venda venda)
        {
            _repository.Adicionar(venda);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public List<Venda> Listar()
        {
            return _repository.Listar();
        }
        public Venda BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }
        public void Editar(Venda editVenda)
        {
            _repository.Editar(editVenda);
        }

    }
}

