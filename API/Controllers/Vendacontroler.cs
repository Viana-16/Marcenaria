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



        /// <summary>
        /// Endpoint para adicionar vendas
        /// </summary>
        /// <param name="VendaDTO"></param>
        /// <returns></returns>

        [HttpPost("adicionar-Venda")]
        public IActionResult Adicionar(CreateVendaDTO VendaDTO)
        {
            try
            {
                Venda venda = _mapper.Map<Venda>(VendaDTO);
                _service.Adicionar(venda);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao adicionar a venda, " +
                    $"o erro foi \n {erro.Message}");
            }
           
        }


        /// <summary>
        /// Endpoint para listar vendas
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpGet("listar-Venda")]
        public List<Venda> Listar()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao listar a venda");
            }
           
        }



        /// <summary>
        /// Endpoint para editar vendas
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        /// 
        [HttpPut("editar-Venda")]
        public IActionResult Editar(Venda v)
        {
            try
            {
                _service.Editar(v);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao editar a venda, " +
                    $"o erro foi \n {erro.Message}");
            }
            
        }



        /// <summary>
        /// Endpoint para deletar vendas
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete("deletar-Venda")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _service.Remover(id);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao deletar a venda, " +
                     $"o erro foi \n {erro.Message}");
            }
            
        }



        /// <summary>
        /// Endpoint para buscar vendas por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        [HttpGet("Buscar-Venda-por-Id")]
        public Venda BuscarPorId(int id)
        {
            try
            {
                return _service.BuscarPorId(id);
            }
            catch (Exception)
            {

                throw new Exception("Erro ao Buscar a venda por id");
            }
            
        }
    }
}
