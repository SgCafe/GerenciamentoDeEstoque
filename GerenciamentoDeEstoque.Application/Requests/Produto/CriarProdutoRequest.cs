namespace GerenciamentoDeEstoque.Application.Requests.Produto;

public class CriarProdutoRequest
{
    #region Properties

    public string Nome { get; private set; }
    public decimal Preco { get; private set; }
    public string CodigoDeBarras { get; private set; }

    #endregion Properties

    #region Constructors

    public CriarProdutoRequest(string nome, decimal preco, string codigoDeBarras)
    {
        Nome = nome;
        Preco = preco;
        CodigoDeBarras = codigoDeBarras;
    }

    #endregion Constructors
}