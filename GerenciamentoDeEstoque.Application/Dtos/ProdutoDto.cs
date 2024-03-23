namespace GerenciamentoDeEstoque.Application.Dtos;

public class ProdutoDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public string CodigoDeBarras { get; set; }
}