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

        /// <summary>
        /// Endpoint para adicionar clientes
        /// </summary>
        /// <param name="clienteDTO"></param>



        [HttpPost("adicionar-Clientes")]
        public IActionResult Adicionar(CreateClienteDTO clienteDTO)
        {
            try
            {
                Cliente clientes = _mapper.Map<Cliente>(clienteDTO);
                _service.Adicionar(clientes);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao adicionar Aluno, " +
                    $"o erro foi \n {erro.Message}");
            }


            
        }
        [HttpGet("listar-Clientes")]
        public List<Cliente> Listar()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Clientes")]
        public IActionResult Editar(Cliente c)
        {
            _service.Editar(c);
            return NoContent();
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

