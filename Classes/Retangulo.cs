namespace OrientacaoObjetosC_;

public class Retangulo
{
    public double Altura;
    public double Largura;

    public double RetanguloArea()
    {
        return Largura * Altura;
    }
    public double RetanguloPerimetro()
    {
        return 2 * (Largura + Altura);
    }
    public double RetanguloDiagonal()
    {
        return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
    }
}
