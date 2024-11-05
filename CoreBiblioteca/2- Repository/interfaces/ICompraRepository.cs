using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._2__Repository.interfaces
{
    public interface ICompraRepository
    {
        void Adicionar(Compra compra);

        void Remover(int id);

        void Editar(Compra compra);

        List<Compra> Listar();

        Compra BuscarPorId(int id);
       
    }
}
