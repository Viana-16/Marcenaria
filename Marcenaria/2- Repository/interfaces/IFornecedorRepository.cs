using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._2__Repository.interfaces
{
    public interface IFornecedorRepository
    {
        void Adicionar(Fornecedor fornecedor);

        void Remover(int id);

        void Editar(Fornecedor fornecedor);

        List<Fornecedor> Listar();

        Fornecedor BuscarPorId(int id);
       
    }
}
