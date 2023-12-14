// See https://aka.ms/new-console-template for more information
using OrientacaoObjetosC_;

Pessoa Pessoa1, Pessoa2, Pessoa3, Pessoa4;

Pessoa1 = new Pessoa();
Pessoa2 = new Pessoa();

System.Console.Write("Digite o nome da primeira pessoa: ");
Pessoa1.Nome = Console.ReadLine();
System.Console.Write("Digite a idade da primeira pessoa: ");
Pessoa1.Idade = int.Parse(Console.ReadLine());

System.Console.Write("Digite o nome da segunda pessoa: ");
Pessoa1.Nome = Console.ReadLine();
Pessoa2.Nome = "Joao";
System.Console.Write("Digite a idade da segunda pessoa: ");
Pessoa2.Idade = int.Parse(Console.ReadLine());


if (Pessoa1.Idade > Pessoa2.Idade)
{
    System.Console.WriteLine($"{Pessoa1.Nome} é mais velha!");
}
else
{
    System.Console.WriteLine($"{Pessoa2.Nome} é mais velha!");
}

Pessoa3 = new Pessoa();
Pessoa4 = new Pessoa();


Pessoa3.Nome = "Carlos Silva";
Pessoa3.Salario = 6300;

Pessoa4.Nome = "Ana Marques";
Pessoa4.Salario = 6700;

double media = (double)((Pessoa3.Salario + Pessoa4.Salario) / 2);

System.Console.WriteLine(media);