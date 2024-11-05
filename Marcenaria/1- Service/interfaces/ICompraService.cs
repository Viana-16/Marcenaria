using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._1__Service.interfaces
{
    public interface ICompraService
    {
        void Adicionar(Compra compra);



         void Remover(int id);



         List<Compra> Listar();


         Compra BuscarPorId(int id);


         void Editar(Compra editCompra);
        
    }
}
