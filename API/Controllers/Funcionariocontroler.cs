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
        [HttpPost("adicionar-Funcionario")]
        public void Adicionar(CreateFuncionarioDTO funcionarioDTO)
        {
            Funcionario funcionario = _mapper.Map<Funcionario>(funcionarioDTO);
            _service.Adicionar(funcionario);
        }
        [HttpGet("listar-Funcionario")]
        public List<Funcionario> Listar()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Funcionario")]
        public void Editar(Funcionario f)
        {
            _service.Editar(f);
        }
        [HttpDelete("deletar-Funcionario")]
        public void Deletar(int id)
        {
            _service.Remover(id);
        }
        [HttpGet("Buscar-Funcionario-por-Id")]
        public Funcionario BuscarPorId(int id)
        {
            return _service.BuscarPorId(id);
        }
    }
}
