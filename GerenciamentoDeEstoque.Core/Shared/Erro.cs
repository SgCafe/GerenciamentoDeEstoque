namespace GerenciamentoDeEstoque.Core.Shared;

public class Erro
{
    public string Mensagem { get; private set; }

    public Erro(string mensagem)
    {
        Mensagem = mensagem;
    }

    public static Erro NenhumErro() => new Erro("");
}