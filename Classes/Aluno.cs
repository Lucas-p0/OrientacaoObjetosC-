namespace OrientacaoObjetosC_;

public class Aluno
{
    public string Nome;
    public double Nota1;
    public double Nota2;
    public double Nota3;

    public double Media()
    {
        double soma = Nota1 + Nota2 + Nota3;
        double mediaResultado = soma / 3;

        if (mediaResultado >= 60)
        {
            Console.WriteLine("Aluno aprovado!");
        }
        else
        {
            Console.WriteLine("Aluno reprovado");
        }
    }

}
