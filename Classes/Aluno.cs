namespace OrientacaoObjetosC_;

public class Aluno
{
    public string? Nome;
    public double Nota1;
    public double Nota2;
    public double Nota3;

    public double Soma()
    {
        double soma = Nota1 + Nota2 + Nota3;
        return soma;
    }
    public double Media()
    {

        double mediaResultado = Soma() / 3;
        return (double)mediaResultado;


    }
    public bool Aprovado()
    {
        if (Media() >= 60)
        {
            Console.WriteLine("Aluno aprovado!");
            return true;
        }
        else
        {
            Console.WriteLine("Aluno reprovado");
            return false;
        }
    }
    public double Avaliacao()
    {
        if (Aprovado())
        {
            return 0.0;
        }
        else
        {
            return 60.0 - Soma();
        }
    }

}
