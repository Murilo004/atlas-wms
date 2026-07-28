using AtlasWMS.Domain.Entities;

namespace AtlasWMS.Domain.Interfaces.Repositories;

public interface ICategoriaRepository
{
    Categoria? ObterPorId(int id);

    IEnumerable<Categoria> ObterTodas();

    void Adicionar(Categoria categoria);

    void Atualizar(Categoria categoria);
}