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
        [HttpPost("adicionar-Produto")]
        public void Adicionar(CreateProdutosDTO produtoDTO)
        {
            Produtos produto = _mapper.Map<Produtos>(produtoDTO);
            _service.Adicionar(produto);
        }
        [HttpGet("listar-produto")]
        public List<Produtos> Listar()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Produto")]
        public void Editar(Produtos p)
        {
            _service.Editar(p);
        }
        [HttpDelete("deletar-Produto")]
        public void Deletar(int id)
        {
            _service.Remover(id);
        }
        [HttpGet("Buscar-Produto-por-Id")]
        public Produtos BuscarPorId(int id)
        {
            return _service.BuscarPorId(id);
        }
    }
}
