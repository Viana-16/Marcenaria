using AutoMapper;
using Marcenaria._1__Service;
using Marcenaria._1__Service.interfaces;
using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Materialcontroller : ControllerBase
    {
        private readonly IMaterialService _service;
        private readonly IMapper _mapper;
        public Materialcontroller(IConfiguration config, IMapper mapper, IMaterialService service)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = service;
            _mapper = mapper;
        }
        [HttpPost("adicionar-Material")]
        public void Adicionar(CreateMaterialDTO materialDTO)
        {
            Material material = _mapper.Map<Material>(materialDTO);
            _service.Adicionar(material);
        }
        [HttpGet("listar-Material")]
        public List<Material> Listar()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Material")]
        public void Editar(Material m)
        {
            _service.Editar(m);
        }
        [HttpDelete("deletar-Material")]
        public void Deletar(int id)
        {
            _service.Remover(id);
        }
        [HttpGet("Buscar-Material-por-Id")]
        public Material BuscarPorId(int id)
        {
            return _service.BuscarPorId(id);
        }
    }
}
