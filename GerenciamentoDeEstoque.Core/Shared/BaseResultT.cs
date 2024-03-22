namespace GerenciamentoDeEstoque.Core.Shared;

public class BaseResult<T> : BaseResult
{
    public T Valor { get; set; }

    protected internal BaseResult(T valor, bool sucesso, Erro erro) : base(sucesso, erro)
    {
        Valor = valor;
    }

    public static implicit operator BaseResult<T>(T value) => Criar(value);
}