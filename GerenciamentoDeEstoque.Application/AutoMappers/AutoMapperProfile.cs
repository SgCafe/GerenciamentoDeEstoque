using AutoMapper;
using GerenciamentoDeEstoque.Application.Dtos;
using GerenciamentoDeEstoque.Application.Requests.Produto;

namespace GerenciamentoDeEstoque.Application.AutoMappers;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<CriarProdutoRequest, ProdutoDto>()
            .ReverseMap();
    }
}