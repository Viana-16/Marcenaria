using Marcenaria._1__Service.interfaces;
using Marcenaria._2__Repository;
using Marcenaria._2__Repository.interfaces;
using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._1__Service
{
    public class MaterialService : IMaterialService
    {
        private readonly IMaterialRepository _repository;
        public MaterialService(IMaterialRepository repository)
        {
            _repository = repository;
        }
        public void Adicionar(Material material)
        {
            _repository.Adicionar(material);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public List<Material> Listar()
        {
            return _repository.Listar();
        }
        public Material BuscarPorId(int id)
        {
           return _repository.BuscarPorId(id);
        }
        public void Editar(Material editMaterial)
        {
            _repository.Editar(editMaterial);
        }

    }
}

