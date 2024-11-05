using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Marcenaria._3__Entidades.DTO
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<CreateProdutosDTO, Produtos>().ReverseMap();
            CreateMap<CreateFornecedorDTO, Fornecedor>().ReverseMap();
            CreateMap<CreateClienteDTO, Cliente>().ReverseMap();
            CreateMap<CreateCompraDTO, Compra>().ReverseMap();
            CreateMap<CreateFuncionarioDTO, Funcionario>().ReverseMap();
            CreateMap<CreateMaterialDTO, Material>().ReverseMap();
            CreateMap<CreateVendaDTO, Venda>().ReverseMap();
        }
    }
}
