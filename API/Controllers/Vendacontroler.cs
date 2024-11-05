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
    public class Vendacontroller : ControllerBase
    {
        private readonly IVendaService _service;
        private readonly IMapper _mapper;
        public Vendacontroller(IConfiguration config, IMapper mapper, IVendaService service)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = service;
            _mapper = mapper;
        }
        [HttpPost("adicionar-Venda")]
        public void Adicionar(CreateVendaDTO VendaDTO)
        {
            Venda venda = _mapper.Map<Venda>(VendaDTO);
            _service.Adicionar(venda);
        }
        [HttpGet("listar-Venda")]
        public List<Venda> Listar()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Venda")]
        public void Editar(Venda v)
        {
            _service.Editar(v);
        }
        [HttpDelete("deletar-Venda")]
        public void Deletar(int id)
        {
            _service.Remover(id);
        }
        [HttpGet("Buscar-Venda-por-Id")]
        public Venda BuscarPorId(int id)
        {
            return _service.BuscarPorId(id);
        }
    }
}
