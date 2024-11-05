using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._1__Service.interfaces
{
    public interface IVendaService
    {
        void Adicionar(Venda venda);

         void Remover(int id);


        List<Venda> Listar();

        Venda BuscarPorId(int id);


         void Editar(Venda editVenda);
        
    }
}
