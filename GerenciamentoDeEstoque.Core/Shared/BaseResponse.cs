namespace GerenciamentoDeEstoque.Core.Shared;

public class BaseResponse<T>
{
    public T Data { get; private set; }
    public Erro Erro { get; private set; }

    public BaseResponse(T data)
    {
        Data = data;
        Erro = Erro.NenhumErro();
    }

    public BaseResponse(Erro erro)
    {
        Data = default;
        Erro = erro;
    }
}