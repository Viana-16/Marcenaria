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
    public class Materialcontroller : ControllerBase
    {
        private readonly IMaterialService _service;
        private readonly IMapper _mapper;
        public Materialcontroller(IConfiguration config, IMapper mapper, IMaterialService service)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// Endpoint para adicionar materiais
        /// </summary>
        /// <param name="materialDTO"></param>
        /// <returns></returns>

        [HttpPost("adicionar-Material")]
        public IActionResult Adicionar(CreateMaterialDTO materialDTO)
        {
            try
            {
                Material material = _mapper.Map<Material>(materialDTO);
                _service.Adicionar(material);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao adicionar o material, " +
                    $"o erro foi \n {erro.Message}");
            }
           
        }


        /// <summary>
        /// Endpoint para listar materiais
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        [HttpGet("listar-Material")]
        public List<Material> Listar()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao listar material por id");
            }
            
        }



        /// <summary>
        /// Endpoint para editar materiais
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>

        [HttpPut("editar-Material")]
        public IActionResult Editar(Material m)
        {
            try
            {
                _service.Editar(m);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao editar o material, " +
                     $"o erro foi \n {erro.Message}");
            }
            
        }



        /// <summary>
        /// Endpoint para deletar materiais
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete("deletar-Material")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _service.Remover(id);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao deletar o material, " +
                      $"o erro foi \n {erro.Message}");
            }
            
        }


        /// <summary>
        /// Endpoint para buscar materiais por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        [HttpGet("Buscar-Material-por-Id")]
        public Material BuscarPorId(int id)
        {
            try
            {
               return _service.BuscarPorId(id); 
            }
            catch (Exception)
            {

                throw new Exception("Erro ao Buscar material por id");
            }
            
        }
    }
}
