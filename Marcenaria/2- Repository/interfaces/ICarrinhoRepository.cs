using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._2__Repository.interfaces
{
    public interface ICarrinhoRepository
    {
        void Adicionar(Carrinho carrinho);
        void Remover(int id);
        void Editar(Carrinho carrinho);
        List<Carrinho> Listar();
        List<Readcarrinho> ListarCarrinhoDoUsuario(int clienteId);
        Carrinho BuscarPorId(int id);
    }
}
