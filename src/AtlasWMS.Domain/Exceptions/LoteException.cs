namespace AtlasWMS.Domain.Exceptions;

public class LoteException : Exception
{
    public LoteException(string mensagem) 
        : base(mensagem)
    {  
    }
}