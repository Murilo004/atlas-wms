using AtlasWMS.Domain.Entities;

namespace AtlasWMS.Domain.Interfaces.Repositories;

public interface ILoteRepository
{
    Lote? ObterPorId(int id);
    IEnumerable<Lote> ObterTodos();
    void Adicionar(Lote lote);
    void Atualizar(Lote lote);
}