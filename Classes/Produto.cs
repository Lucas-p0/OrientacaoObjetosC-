using System.Globalization;

namespace OrientacaoObjetosC_;

public class Produto
{
    public string? Nome;
    public double Preco;
    public int Quantidade;


    public double ValorTotalEmEstoque()
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
    public override string ToString()
    {
        return Nome
        + ", $"
        + Preco.ToString("F2", CultureInfo.InvariantCulture)
        + ", "
        + Quantidade
        + " Unidades, Total:$"
        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }

}
