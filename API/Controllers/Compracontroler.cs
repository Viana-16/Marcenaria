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
    public class Compracontroller : ControllerBase
    {
        private readonly ICompraService _service;
        private readonly IMapper _mapper;
        public Compracontroller(IConfiguration config, IMapper mapper, ICompraService service)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = service;
            _mapper = mapper;
        }
        [HttpPost("adicionar-Compra")]
        public void Adicionar(CreateCompraDTO compraDTO)
        {
            Compra compra = _mapper.Map<Compra>(compraDTO);
            _service.Adicionar(compra);
        }
        [HttpGet("listar-Compra")]
        public List<Compra> Listar()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Compra")]
        public void Editar(Compra c)
        {
            _service.Editar(c);
        }
        [HttpDelete("deletar-Compra")]
        public void Deletar(int id)
        {
            _service.Remover(id);
        }
        [HttpGet("Buscar-Compra-por-Id")]
        public Compra BuscarPorId(int id)
        {
            return _service.BuscarPorId(id);
        }
    }
}
