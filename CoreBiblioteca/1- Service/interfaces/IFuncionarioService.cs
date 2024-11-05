using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._1__Service.interfaces
{
    public interface IFuncionarioService
    {
        void Adicionar(Funcionario funcionario);



         void Remover(int id);



         List<Funcionario> Listar();


         Funcionario BuscarPorId(int id);


         void Editar(Funcionario editFuncionario);
        
    }
}
