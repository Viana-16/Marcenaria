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
        [HttpPost("adicionar-carrinho")]
        public void AdicionarAluno(Carrinho carrinhoDTO)
        {
            Carrinho carrinho = _mapper.Map<Carrinho>(carrinhoDTO);
            _service.Adicionar(carrinho);
        }
        [HttpGet("listar-carrinho")]
        public List<Carrinho> ListarAluno()
        {
            return _service.Listar();
        }
        [HttpGet("listar-carrinho-do-usuario")]
        public List<Readcarrinho> ListarCarrinhoDoUsuario([FromQuery] int clienteId)
        {
            return _service.ListarCarrinhoDoUsuario(clienteId);
        }
        [HttpPut("editar-carrinho")]
        public void EditarCarrinho(Carrinho c)
        {
            _service.Editar(c);
        }
        [HttpDelete("deletar-carrinho")]
        public void DeletarCarrinho(int id)
        {
            _service.Remover(id);
        }

    }
}


