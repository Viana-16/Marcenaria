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
        [HttpPost("adicionar-Fornecedor")]
        public void Adicionar(CreateFornecedorDTO fornecedorDTO)
        {
            Fornecedor fornecedor = _mapper.Map<Fornecedor>(fornecedorDTO);
            _service.Adicionar(fornecedor);
        }
        [HttpGet("listar-Fornecedor")]
        public List<Fornecedor> Listar()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Fornecedor")]
        public void Editar(Fornecedor f)
        {
            _service.Editar(f);
        }
        [HttpDelete("deletar-Fornecedor")]
        public void Deletar(int id)
        {
            _service.Remover(id);
        }
        [HttpGet("Buscar-Fornecedor-por-Id")]
        public Fornecedor BuscarPorId(int id)
        {
            return _service.BuscarPorId(id);
        }
    }
    

    
}
