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
    public class Clientecontroller : ControllerBase
    {
        private readonly IClienteService _service;
        private readonly IMapper _mapper;
        public Clientecontroller(IConfiguration config, IMapper mapper, IClienteService service)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = service;
            _mapper = mapper;
        }
        [HttpPost("adicionar-Clientes")]
        public void Adicionar(CreateClienteDTO clienteDTO)
        {
            Cliente clientes = _mapper.Map<Cliente>(clienteDTO);
            _service.Adicionar(clientes);
        }
        [HttpGet("listar-Clientes")]
        public List<Cliente> Listar()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Clientes")]
        public void Editar(Cliente c)
        {
            _service.Editar(c);
        }
        [HttpDelete("deletar-Clientes")]
        public void Deletar(int id)
        {
            _service.Remover(id);
        }
        [HttpGet("Buscar-Cliente-por-Id")]
        public Cliente BuscarPorId(int id)
        {
            return _service.BuscarPorId(id);
        }
    }
}

