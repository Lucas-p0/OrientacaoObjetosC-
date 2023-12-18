namespace OrientacaoObjetosC_;

public class Cotacao
{

    public double CotacaoDolar;
    public double QuantidadeDolar;

    public double Porcentagem = 6;

    public double Real;

    public double CalculoCotacaoDolar()
    {
        double soma = CotacaoDolar * QuantidadeDolar;
        return soma * Porcentagem / 100;
    }
}
