namespace OrientacaoObjetosC_;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;


    public double ValorTotalEmEstoque()
    {

        double valorDeEstoque = Preco * Quantidade;
        return valorDeEstoque;
    }

}
