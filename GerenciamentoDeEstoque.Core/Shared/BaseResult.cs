namespace GerenciamentoDeEstoque.Core.Shared;

public class BaseResult
{
    #region Properties

    public bool Sucesso { get; }
    public bool Falha => !Sucesso;
    public Erro Erro { get; }

    #endregion Properties

    #region Constructors

    protected BaseResult(bool sucesso, Erro erro)
    {
        Sucesso = sucesso;
        Erro = erro;
    }

    #endregion Constructors

    #region Methods

    public static BaseResult Concluido() => new BaseResult(true, Erro.NenhumErro());
    public static BaseResult<T> Concluido<T>(T value) => new BaseResult<T>(value, true, Erro.NenhumErro());

    public static BaseResult Falhou(string mensagem) => new BaseResult(false, new Erro(mensagem));
    public static BaseResult<T> Falhou<T>(string mensagem) => new BaseResult<T>(default, false, new Erro(mensagem));

    protected static BaseResult<T> Criar<T>(T value) => value != null ? Concluido(value) : Falhou<T>("");

    #endregion
}