namespace AtlasWMS.Domain.Exceptions;

public class ProdutoException : Exception
{
    public ProdutoException(string mensagem)
        : base(mensagem)
    {
    }
}