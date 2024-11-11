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
    public class Funcionariocontroller : ControllerBase
    {
        private readonly IFuncionarioService _service;
        private readonly IMapper _mapper;
        public Funcionariocontroller(IConfiguration config, IMapper mapper, IFuncionarioService service)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = service;
            _mapper = mapper;
        }



        /// <summary>
        /// Endpoint para adicionar funcionarios
        /// </summary>
        /// <param name="funcionarioDTO"></param>
        /// <returns></returns>

        [HttpPost("adicionar-Funcionario")]
        public IActionResult Adicionar(CreateFuncionarioDTO funcionarioDTO)
        {

            try
            {
                Funcionario funcionario = _mapper.Map<Funcionario>(funcionarioDTO);
                _service.Adicionar(funcionario);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao adicionar o Funcionario, " +
                   $"o erro foi \n {erro.Message}");
            }
            
        }


        /// <summary>
        /// Endpoint para listar funcionarios
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        [HttpGet("listar-Funcionario")]
        public List<Funcionario> Listar()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao listar funcionario");
            }
            
        }


        /// <summary>
        /// Endpoint para editar funcionarios
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>

        [HttpPut("editar-Funcionario")]
        public IActionResult Editar(Funcionario f)
        {

            try
            {
                _service.Editar(f);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao Editar o Funcionario, " +
                   $"o erro foi \n {erro.Message}");
            }
            
        }




        /// <summary>
        /// Endpoint para deletar funcionarios
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete("deletar-Funcionario")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _service.Remover(id);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao deletar o funcionario, " +
                   $"o erro foi \n {erro.Message}");
            }
            
        }




        /// <summary>
        /// Endpoint para buscar funcionarios por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        [HttpGet("Buscar-Funcionario-por-Id")]
        public Funcionario BuscarPorId(int id)
        {
            try
            {
                return _service.BuscarPorId(id);
            }
            catch (Exception)
            {

                throw new Exception("Erro ao buscar Funcionario por id");
            }
            
        }
    }
}
