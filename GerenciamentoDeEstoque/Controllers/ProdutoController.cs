using GerenciamentoDeEstoque.Abstractions;
using GerenciamentoDeEstoque.Application.Requests.Produto;
using GerenciamentoDeEstoque.Application.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoDeEstoque.Controllers;

[Route("api/[controller]")]
public class ProdutoController : ApiController
{
    private readonly IProdutoService _produtoService;

    public ProdutoController(IProdutoService produtoService)
    {
        _produtoService = produtoService;
    }

    [HttpPost]
    public async Task<ActionResult> CriarProduto([FromBody] CriarProdutoRequest request)
    {
        var result = await _produtoService.CriarProduto(request);
        return Retorno(result, "Cadastro feito com sucesso.");
    }
}