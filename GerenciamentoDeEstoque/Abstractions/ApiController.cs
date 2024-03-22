using System.Net;
using GerenciamentoDeEstoque.Core.Shared;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoDeEstoque.Abstractions;

[ApiController]
public abstract class ApiController : ControllerBase
{
    protected ActionResult Retorno(
        BaseResult result, 
        string mensagem = "",
        HttpStatusCode statusSucesso = HttpStatusCode.OK, 
        HttpStatusCode statusFalha = HttpStatusCode.NotFound)
    {
        if (result.Falha)
        {
            return StatusCode((int)statusFalha, new BaseResponse<Erro>(result.Erro));
        }

        return StatusCode((int)statusSucesso, new BaseResponse<object>(mensagem));
    }
    
    protected ActionResult Retorno<T>(
        BaseResult<T> result,
        HttpStatusCode statusSucesso = HttpStatusCode.OK, 
        HttpStatusCode statusFalha = HttpStatusCode.NotFound)
    {
        if (result.Falha)
        {
            return StatusCode((int)statusFalha, new BaseResponse<Erro>(result.Erro));
        }

        return StatusCode((int)statusSucesso, new BaseResponse<T>(result.Valor));
    }
}