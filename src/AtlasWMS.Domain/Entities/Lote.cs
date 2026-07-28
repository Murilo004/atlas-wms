using AtlasWMS.Domain.Enums;
using AtlasWMS.Domain.Exceptions;

namespace AtlasWMS.Domain.Entities;

public class Lote
{
    private const int TamanhoMaximoNumero = 50;
    public int Id { get; private set; }
    public string Numero { get; private set; }
    public Produto Produto { get; private set; }
    public int Quantidade { get; private set; }
    public DateOnly DataFabricacao { get; private set; }
    public DateOnly DataValidade { get; private set; }
    public Status Status { get; private set; }

    public Lote(string numero, Produto produto, int quantidade, DateOnly dataFabricacao, DateOnly dataValidade)
    {
        ValidarNumero(numero);
        ValidarProduto(produto);
        ValidarQuantidade(quantidade);
        ValidarDataFabricacao(dataFabricacao);
        ValidarDataValidade(dataValidade, dataFabricacao);

        Numero = numero;
        Produto = produto;
        Quantidade = quantidade;
        DataFabricacao = dataFabricacao;
        DataValidade = dataValidade;
        Status = Status.Ativo;
    }

    private void ValidarNumero(string numero)
    {
        if (string.IsNullOrWhiteSpace(numero))
        {
            throw new LoteException("O número do lote é obrigatório.");
        }

        if(numero.Length > TamanhoMaximoNumero)
        {
            throw new LoteException("O número do lote não pode ultrapassar 50 caracteres.");
        }
    }

    private void ValidarProduto(Produto produto)
    {
        if(produto == null)
        {
            throw new LoteException("O produto do lote é obrigatório.");
        }
    }

    private void ValidarQuantidade(int quantidade)
    {
        if(quantidade <= 0)
        {
            throw new LoteException("A quantidade do lote deve ser maior que zero.");
        }
    }

    private void ValidarDataFabricacao(DateOnly dataFabricacao)
    {
        if(dataFabricacao == default)
        {
            throw new LoteException("A data de fabricação é obrigatória.");
        }
    }

    private void ValidarDataValidade(DateOnly dataValidade, DateOnly dataFabricacao)
    {
        if(dataValidade == default)
        {
            throw new LoteException("A data de validade é obrigatória.");
        }

        if (dataValidade <= dataFabricacao)
        {
            throw new LoteException("A data de validade deve ser superior a data de fabricação.");
        }
    }
}