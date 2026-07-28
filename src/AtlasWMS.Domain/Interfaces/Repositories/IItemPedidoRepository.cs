using AtlasWMS.Domain.Entities;

namespace AtlasWMS.Domain.Interfaces.Repositories;

public interface IItemPedidoRepository
{
    ItemPedido? ObterPorId(int id);
    IEnumerable<ItemPedido> ObterTodos();
    void Adicionar(ItemPedido itemPedido);
    void Atualizar(ItemPedido itemPedido);
}