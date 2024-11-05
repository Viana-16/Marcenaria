using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._1__Service.interfaces
{
    public interface IFornecedorService
    {
        void Adicionar(Fornecedor fornecedor);



         void Remover(int id);



         List<Fornecedor> Listar();


         Fornecedor BuscarPorId(int id);


         void Editar(Fornecedor editFornecedor);
        
    }
}
