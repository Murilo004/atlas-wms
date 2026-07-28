namespace AtlasWMS.Domain.Exceptions;

public class ItemPedidoException : Exception
{
    public ItemPedidoException(string mensagem)
        : base(mensagem)
    {
    }
}