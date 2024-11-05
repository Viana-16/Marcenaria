using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._2__Repository.interfaces
{
    public interface IMaterialRepository
    {
        void Adicionar(Material material);


         void Remover(int id);


         void Editar(Material material);


         List<Material> Listar();


         Material BuscarPorId(int id);
        
    }
}
