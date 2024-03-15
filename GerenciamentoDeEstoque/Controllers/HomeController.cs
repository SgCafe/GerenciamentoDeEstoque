using GerenciamentoDeEstoque.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoDeEstoque.Controllers;

[Route("api/[controller]")]
public class HomeController : ApiController
{
    [HttpGet]
    public ActionResult Home()
    {
        return Ok("Api está online!");
    }
}