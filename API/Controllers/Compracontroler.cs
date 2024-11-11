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


        /// <summary>
        /// Endpoint para adicionar compras
        /// </summary>
        /// <param name="compraDTO"></param>
        /// <returns></returns>

        [HttpPost("adicionar-Compra")]
        public IActionResult Adicionar(CreateCompraDTO compraDTO)
        {
            try
            {
                Compra compra = _mapper.Map<Compra>(compraDTO);
                _service.Adicionar(compra);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao adicionar a compra, " +
                    $"o erro foi \n {erro.Message}");
            }
            
        }


        /// <summary>
        /// Endpoint para listar compras
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>


        [HttpGet("listar-Compra")]
        public List<Compra> Listar()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao Listar compra");
            }
            
        }


        /// <summary>
        /// Endpoint para editar compras
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>

        [HttpPut("editar-Compra")]
        public IActionResult Editar(Compra c)
        {
            try
            {
                _service.Editar(c);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao editar a compra, " +
                    $"o erro foi \n {erro.Message}");
            }
            
        }



        /// <summary>
        /// Endpoint para deletar compras
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete("deletar-Compra")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _service.Remover(id);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao Deletar a compra, " +
                    $"o erro foi \n {erro.Message}");
            }
            
        }



        /// <summary>
        /// Endpoint para buscar compras por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        [HttpGet("Buscar-Compra-por-Id")]
        public Compra BuscarPorId(int id)
        {
            try
            {
                return _service.BuscarPorId(id);
            }
            catch (Exception)
            {

                throw new Exception("Erro ao Buscar compra por id");
            }
            
        }
    }
}
