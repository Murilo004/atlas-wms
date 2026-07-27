namespace AtlasWMS.Domain.Exceptions;

public class CategoriaException : Exception
{
    public CategoriaException(string mensagem) 
        : base(mensagem)
    {
    }
}