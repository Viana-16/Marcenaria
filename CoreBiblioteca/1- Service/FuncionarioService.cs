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
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepository _repository;
        public FuncionarioService(IFuncionarioRepository repository)
        {
            _repository = repository;
        }
        public void Adicionar(Funcionario funcionario)
        {
            _repository.Adicionar(funcionario);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public List<Funcionario> Listar()
        {
            return _repository.Listar();
        }
        public Funcionario BuscarPorId(int id)
        {
           return _repository.BuscarPorId(id);
        }
        public void Editar(Funcionario editFuncionario)
        {
            _repository.Editar(editFuncionario);
        }

    }
}