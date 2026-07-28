using AtlasWMS.Domain.Entities;

namespace AtlasWMS.Domain.Interfaces.Repositories;

public interface IProdutoRepository
{
    Produto? ObterPorId(int id);

    IEnumerable<Produto> ObterTodos();

    void Adicionar(Produto produto);

    void Atualizar(Produto produto);
}