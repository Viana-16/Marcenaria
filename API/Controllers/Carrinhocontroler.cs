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
    public class CarrinhoController : ControllerBase
    {
        private readonly ICarrinhoService _service;
        private readonly IMapper _mapper;
        public CarrinhoController(IConfiguration config, IMapper mapper, ICarrinhoService service)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = service;
            _mapper = mapper;
        }


        /// <summary>
        /// Endpoint para adicionar Carrinho
        /// </summary>
        /// <param name="carrinhoDTO"></param>

        [HttpPost("adicionar-carrinho")]
        public IActionResult AdicionarCliente(CreateCarrinhoDTO carrinhoDTO)
        {
            try
            {
                Carrinho carrinho = _mapper.Map<Carrinho>(carrinhoDTO);
                _service.Adicionar(carrinho);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao adicionar o carrinho, " +
                    $"o erro foi \n {erro.Message}");
            }
            
        }



        /// <summary>
        /// Endpoint para listar Carrinho
        /// </summary>
        /// <returns></returns>

        [HttpGet("listar-carrinho")]
        public List<Carrinho> ListarCliente()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao listar carrinho");
            }
           
        }


        /// <summary>
        /// Endpoint para listar Carrinho usuario
        /// </summary>
        /// <param name="clienteId"></param>
        /// <returns></returns>

        [HttpGet("listar-carrinho-do-usuario")]
        public List<Readcarrinho> ListarCarrinhoDoUsuario([FromQuery] int clienteId)
        {
            try
            {
                return _service.ListarCarrinhoDoUsuario(clienteId);
            }
            catch (Exception)
            {

                throw new Exception("Erro ao listar carrinho usuario");
            }
           
        }


        /// <summary>
        /// Endpoint para editar Carrinho
        /// </summary>
        /// <param name="c"></param>
        [HttpPut("editar-carrinho")]
        public IActionResult EditarCarrinho(Carrinho c)
        {
            try
            {
                _service.Editar(c);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao editar o carrinho, " +
                    $"o erro foi \n {erro.Message}");
            }
            
        }


        /// <summary>
        /// Endpoint para deletar Carrinho
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("deletar-carrinho")]
        public IActionResult DeletarCarrinho(int id)
        {
            try
            {
                _service.Remover(id);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao remover o carrinho, " +
                    $"o erro foi \n {erro.Message}");
            }
        }

    }
}


