using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._2__Repository.interfaces
{
    public interface IProdutoRepository
    {
        void Adicionar(Produtos produtos);


         void Remover(int id);


         void Editar(Produtos produtos);


         List<Produtos> Listar();


         Produtos BuscarPorId(int id);
        
    }
}
