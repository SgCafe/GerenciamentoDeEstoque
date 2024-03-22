using GerenciamentoDeEstoque.Application.Dtos;
using GerenciamentoDeEstoque.Application.Requests.Produto;
using GerenciamentoDeEstoque.Application.Services.Contracts;
using GerenciamentoDeEstoque.Core.Shared;

namespace GerenciamentoDeEstoque.Application.Services;

public class ProdutoService : IProdutoService
{
    public async Task<BaseResult<ProdutoDto>> CriarProduto(CriarProdutoRequest request)
    {
        if (request.Preco is 0)
        {
            return BaseResult.Falhou<ProdutoDto>("O preço é obrigatório.");
        }

        return new ProdutoDto {Id = 1, Nome = request.Nome};
    }
}