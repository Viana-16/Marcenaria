using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._2__Repository.interfaces
{
    public interface IVendaRepository
    {
        void Adicionar(Venda venda);


         void Remover(int id);


        void Editar(Venda venda);


         List<Venda> Listar();


         Venda BuscarPorId(int id);
        
    }
}
