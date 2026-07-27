using AtlasWMS.Domain.Enums;
using AtlasWMS.Domain.Exceptions;

namespace AtlasWMS.Domain.Entities;

public class Categoria
{
    private const int TamanhoMaximoNome = 50;

    public int Id { get; private set; }
    public string Nome { get; private set; }
    public Status Status { get; private set; }

    public Categoria(string nome)
    {
        ValidarNome(nome);

        Nome = nome;
        Status = Status.Ativo;
    }

    private void ValidarNome(string nome)
    {
        if(string.IsNullOrWhiteSpace(nome))
        {
            throw new CategoriaException("O nome da categoria é obrigatório.");
        }

        if(nome.Length > TamanhoMaximoNome)
        {
            throw new CategoriaException("O nome da categoria não pode ultrapassar 50 caracteres.");
        }
    }
}