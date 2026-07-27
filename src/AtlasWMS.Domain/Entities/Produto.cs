using AtlasWMS.Domain.Enums;
using AtlasWMS.Domain.Exceptions;

namespace AtlasWMS.Domain.Entities;

public class Produto
{
    private const int TamanhoMaximoNome = 50;
    private const int TamanhoMaximoDescricao = 500;

    public int Id { get; private set; }
    public string Nome { get; private set; }
    public Categoria Categoria { get; private set; }
    public decimal PrecoAtual { get; private set; }
    public string? Descricao { get; private set; }
    public Status Status { get; private set; }

    public Produto(string nome, Categoria categoria, decimal precoAtual, string? descricao)
    {
        ValidarNome(nome);
        ValidarCategoria(categoria);
        ValidarPreco(precoAtual);
        ValidarDescricao(descricao);

        Nome = nome;
        Categoria = categoria;
        PrecoAtual = precoAtual;
        Descricao = descricao;
        Status = Status.Ativo;
    }

    private void ValidarNome(string nome)
    {
        if(string.IsNullOrWhiteSpace(nome))
        {
            throw new ProdutoException("O nome do produto é obrigatório.");
        }

        if(nome.Length > TamanhoMaximoNome)
        {
            throw new ProdutoException("O nome do produto não pode ultrapassar 50 caracteres.");
        }
    }

    private void ValidarCategoria(Categoria categoria)
    {
        if (categoria == null)
        {
            throw new ProdutoException("A categoria do produto é obrigatória.");
        }
    }

    private void ValidarPreco(decimal preco)
    {
        if(preco <= 0)
        {
            throw new ProdutoException("O preço do produto deve ser maior que zero.");
        }
    }

    private void ValidarDescricao(string? descricao)
    {
        if (!string.IsNullOrWhiteSpace(descricao))
        {
            if(descricao.Length > TamanhoMaximoDescricao)
            {
                throw new ProdutoException("A descrição do produto não pode ultrapassar 500 caracteres.");
            }
        }
    }
}