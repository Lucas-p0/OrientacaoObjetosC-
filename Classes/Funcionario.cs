namespace OrientacaoObjetosC_;

public class Funcionario
{
    public string Nome;
    public double SalarioBruto;
    public double Imposto;

    public double SalarioLiquido()
    {
        return (double)(SalarioBruto - Imposto);
    }
    public double AumentarSalario(double porcentagem) => SalarioBruto += porcentagem / SalarioBruto * 100.00;
}
