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
    public class Produtocontroller : ControllerBase
    {
        private readonly IProdutoService _service;
        private readonly IMapper _mapper;
        public Produtocontroller(IConfiguration config, IMapper mapper, IProdutoService service)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// Endpoint para adicionar produtos
        /// </summary>
        /// <param name="produtoDTO"></param>
        /// <returns></returns>

        [HttpPost("adicionar-Produto")]
        public IActionResult Adicionar(CreateProdutosDTO produtoDTO)
        {
            try
            {
                Produtos produto = _mapper.Map<Produtos>(produtoDTO);
                _service.Adicionar(produto);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao adicionar o produto, " +
                    $"o erro foi \n {erro.Message}");

            }
            
        }


        /// <summary>
        /// Endpoint para listar produtos
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        [HttpGet("listar-produto")]
        public List<Produtos> Listar()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao listar produto");
            }
            
        }


        /// <summary>
        /// Endpoint para editar produtos
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>

        [HttpPut("editar-Produto")]
        public IActionResult Editar(Produtos p)
        {
            try
            {
                _service.Editar(p);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao editar o produto, " +
                    $"o erro foi \n {erro.Message}");
            }
            
        }



        /// <summary>
        /// Endpoint para deletar produtos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete("deletar-Produto")]
        public IActionResult Deletar(int id)
        {
            try
            {
               _service.Remover(id); 
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao deletar o produto, " +
                     $"o erro foi \n {erro.Message}");
            }
            
        }



        /// <summary>
        /// Endpoint para buscar produtos por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        [HttpGet("Buscar-Produto-por-Id")]
        public Produtos BuscarPorId(int id)
        {
            try
            {
                return _service.BuscarPorId(id);
            }
            catch (Exception)
            {

                throw new Exception("Erro ao Buscar produto por id");
            }
           
        }
    }
}
