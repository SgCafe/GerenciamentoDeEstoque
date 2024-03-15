using GerenciamentoDeEstoque.Application.Requests.Produto;
using GerenciamentoDeEstoque.Core.Shared;

namespace GerenciamentoDeEstoque.Application.Services.Contracts;

public interface IProdutoService
{
    Task<BaseResult> CriarProduto(CriarProdutoRequest request);
}