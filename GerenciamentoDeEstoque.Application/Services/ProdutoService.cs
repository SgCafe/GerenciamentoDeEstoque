using GerenciamentoDeEstoque.Application.Requests.Produto;
using GerenciamentoDeEstoque.Application.Services.Contracts;
using GerenciamentoDeEstoque.Core.Shared;

namespace GerenciamentoDeEstoque.Application.Services;

public class ProdutoService : IProdutoService
{
    public async Task<BaseResult> CriarProduto(CriarProdutoRequest request)
    {
        if (request.Preco is 0)
        {
            return BaseResult.Falhou("O preço é obrigatório.");
        }

        return BaseResult.Concluido();
    }
}