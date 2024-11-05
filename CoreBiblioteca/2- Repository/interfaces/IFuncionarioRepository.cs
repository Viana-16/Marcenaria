using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._2__Repository.interfaces
{
    public interface IFuncionarioRepository
    {
        void Adicionar(Funcionario funcionario);


         void Remover(int id);


        void Editar(Funcionario funcionario);


         List<Funcionario> Listar();


         Funcionario BuscarPorId(int id);
        
    }
}
