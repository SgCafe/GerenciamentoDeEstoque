using GerenciamentoDeEstoque.Application.Dtos;
using GerenciamentoDeEstoque.Application.Requests.Produto;
using GerenciamentoDeEstoque.Core.Shared;

namespace GerenciamentoDeEstoque.Application.Services.Contracts;

public interface IProdutoService
{
    Task<BaseResult<ProdutoDto>> CriarProduto(CriarProdutoRequest request);
    Task<BaseResult<List<ProdutoDto>>> GetProducts();
}