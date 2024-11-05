using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._1__Service.interfaces
{
    public interface IMaterialService
    {
        void Adicionar(Material material);



         void Remover(int id);


        List<Material> Listar();

        Material BuscarPorId(int id);

        void Editar(Material editMaterial);
        
    }
}
