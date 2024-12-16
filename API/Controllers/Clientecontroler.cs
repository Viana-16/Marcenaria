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
        public IActionResult Adicionar(Cliente clienteDTO)
        {
            try
            {
                Cliente clientes = _mapper.Map<Cliente>(clienteDTO);
                _service.Adicionar(clientes);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao adicionar Cliente, " +
                    $"o erro foi \n {erro.Message}");
            }


            
        }


        /// <summary>
        /// Endpoint para listar clientes
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        /// 



        [HttpGet("listar-Clientes")]
        public List<Cliente> Listar()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao Listar Cliente");
            }
            
        }


        /// <summary>
        /// Endpoint para editar clientes
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        /// 


        [HttpPut("editar-Clientes")]
        public IActionResult Editar(Cliente c)
        {
            try
            {
                _service.Editar(c);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao Editar o Cliente, " +
                   $"o erro foi \n {erro.Message}");

            }
            
        }


        /// <summary>
        /// Endpoint para deletar clientes
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete("deletar-Clientes")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _service.Remover(id);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao deletar o Cliente, " +
                   $"o erro foi \n {erro.Message}");
            }
        }



        /// <summary>
        /// Endpoint para buscar clientes por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        [HttpGet("Buscar-Cliente-por-Id")]
        public Cliente BuscarPorId(int id)
        {
            try
            {
                return _service.BuscarPorId(id);
            }
            catch (Exception)
            {

                throw new Exception("Erro ao buscar Cliente por id");
            }
            
        }
        [HttpPost("Fazer-Login")]
        public Cliente FazerLogin(CreateClienteDTO usuarioLogin)
        {
            Cliente usuario = _service.Fazerlogin(usuarioLogin);
            return usuario;
        }
    }
}

