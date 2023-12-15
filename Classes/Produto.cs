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
