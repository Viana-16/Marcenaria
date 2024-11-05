using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._1__Service.interfaces
{
    public interface IProdutoService
    {
        void Adicionar(Produtos produto);



         void Remover(int id);



         List<Produtos> Listar();


         Produtos BuscarPorId(int id);


         void Editar(Produtos editProduto);
        
        
    }
}
