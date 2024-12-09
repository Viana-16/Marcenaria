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
    public class Fornecedorcontroller : ControllerBase
    {
        private readonly IFornecedorService _service;
        private readonly IMapper _mapper;
        public Fornecedorcontroller(IConfiguration config, IMapper mapper, IFornecedorService service)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = service;
            _mapper = mapper; 
        }

        /// <summary>
        /// Endpoint para adicionar fornecedor
        /// </summary>
        /// <param name="fornecedorDTO"></param>
        /// <returns></returns>
        
        [HttpPost("adicionar-Fornecedor")]
        public IActionResult Adicionar(CreateFornecedorDTO fornecedorDTO)
        {
            try
            {
                Fornecedor fornecedor = _mapper.Map<Fornecedor>(fornecedorDTO);
                _service.Adicionar(fornecedor);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao adicionar o fornecedor, " +
                    $"o erro foi \n {erro.Message}");
            }
            
        }



        /// <summary>
        /// Endpoint para listar fornecedor
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        [HttpGet("listar-Fornecedor")]
        public List<Fornecedor> Listar()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao Listar fornecedor");
            }
            
        }


        /// <summary>
        /// Endpoint para editar fornecedor
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>

        [HttpPut("editar-Fornecedor")]
        public IActionResult Editar(Fornecedor f)
        {
            try
            {
                _service.Editar(f);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao editar o fornecedor, " +
                    $"o erro foi \n {erro.Message}");
            }
           
        }

        /// <summary>
        /// Endpoint para deletar fornecedor
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete("deletar-Fornecedor")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _service.Remover(id);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao deletar o fornecedor, " +
                     $"o erro foi \n {erro.Message}");
            }
            
        }



        /// <summary>
        /// Endpoint para buscar fornecedor por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        [HttpGet("Buscar-Fornecedor-por-Id")]
        public Fornecedor BuscarPorId(int id)
        {
            try
            {
                return _service.BuscarPorId(id);
            }
            catch (Exception)
            {

                throw new Exception("Erro ao Buscar fornecedor por id");
            }
           
        }
    }
    

    
}
