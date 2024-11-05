using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._1__Service.interfaces
{
    public interface ICarrinhoService
    {
        void Adicionar(Carrinho carrinho);
        void Remover(int id);
        List<Carrinho> Listar();
        List<Readcarrinho> ListarCarrinhoDoUsuario(int clienteId);
        Carrinho BuscarTimePorId(int id);
        void Editar(Carrinho editPessoa);
        
    }
}
