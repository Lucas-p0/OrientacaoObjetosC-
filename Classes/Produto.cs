using System.Globalization;

namespace OrientacaoObjetosC_;

public class Produto(string? nome, double preco, int quantidade)
{

    public string? Nome = nome;
    public double Preco = preco;
    public int Quantidade = quantidade;


    public static double ValorTotalEmEstoque(double Preco, int Quantidade)
    {
        double valorDeEstoque = (double)(Preco * Quantidade);
        return valorDeEstoque;

    }
    public void AdicionaQuantidade(int quantidade)
    {
        Quantidade += quantidade;
    }
    public void RemoverQuantidade(int quantidade)
    {
        Quantidade -= quantidade;
    }
    // public override string ToString()
    // {
    //     return Nome
    //     + ", $"
    //     + Preco.ToString("F2", CultureInfo.InvariantCulture)
    //     + ", "
    //     + Quantidade
    //     + " Unidades, Total:$"
    //     + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    // }

}
