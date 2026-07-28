using AtlasWMS.Domain.Exceptions;

namespace AtlasWMS.Domain.Entities;

public class ItemPedido
{
    public int Id { get; private set; }
    public Produto Produto { get; private set; }
    public Lote Lote { get; private set; }
    public int Quantidade { get; private set; }
    public decimal PrecoUnitario { get; private set; }
    public decimal Subtotal => Quantidade * PrecoUnitario;

    public ItemPedido(Produto produto, Lote lote, int quantidade)
    {
        ValidarProduto(produto);
        ValidarLote(produto, lote);
        ValidarQuantidade(quantidade);

        Produto = produto;
        Lote = lote;
        Quantidade = quantidade;
        PrecoUnitario = Produto.PrecoAtual;
    }

    private void ValidarProduto(Produto produto)
    {
        if (produto == null)
        {
            throw new ItemPedidoException("O produto do item do pedido é obrigatório.");
        }
    }

    private void ValidarLote(Produto produto, Lote lote)
    {
        if(lote == null)
        {
            throw new ItemPedidoException("O lote do item do pedido é obrigatório.");
        }

        if(lote.Produto != produto)
        {
            throw new ItemPedidoException("O lote informado não pertence ao produto.");
        }
    }

    private void ValidarQuantidade(int quantidade)
    {
        if(quantidade <= 0)
        {
            throw new ItemPedidoException("A quantidade do item do pedido deve ser maior que zero.");
        }
    }
}