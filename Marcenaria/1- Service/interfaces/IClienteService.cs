using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._1__Service.interfaces
{
    public interface IClienteService
    {
        void Adicionar(Cliente clientes);



         void Remover(int id);



         List<Cliente> Listar();


         Cliente BuscarPorId(int id);


         void Editar(Cliente editClientes);
        
    }
}
