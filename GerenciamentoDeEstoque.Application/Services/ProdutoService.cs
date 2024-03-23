using AutoMapper;
using GerenciamentoDeEstoque.Application.Dtos;
using GerenciamentoDeEstoque.Application.Requests.Produto;
using GerenciamentoDeEstoque.Application.Services.Contracts;
using GerenciamentoDeEstoque.Core.Shared;

namespace GerenciamentoDeEstoque.Application.Services;

public class ProdutoService : IProdutoService
{
    private readonly IMapper _mapper;
    public ProdutoService(IMapper mapper)
    {
        _mapper = mapper;
    }
    
    public async Task<BaseResult<ProdutoDto>> CriarProduto(CriarProdutoRequest request)
    {
        if (request.Preco is 0)
        {
            return BaseResult.Falhou<ProdutoDto>("O preço é obrigatório.");
        }

        return new ProdutoDto {Id = 1, Nome = request.Nome};
    }

    public async Task<BaseResult<List<ProdutoDto>>> GetProducts()
    {
        var products = new List<CriarProdutoRequest>()
        {
            new CriarProdutoRequest("Pão de forma", 13.90m, "123321123321")
            {
            },
            new CriarProdutoRequest("Queijo Minas",29.90m,"1212125555555")
            {
            }
        };

        return _mapper.Map<List<ProdutoDto>>(products);
    }
}