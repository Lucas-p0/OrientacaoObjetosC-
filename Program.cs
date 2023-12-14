// See https://aka.ms/new-console-template for more information
using OrientacaoObjetosC_;

Pessoa Pessoa1, Pessoa2;

Pessoa1 = new Pessoa();
Pessoa2 = new Pessoa();

Pessoa1.Nome = "Maria";
Pessoa1.Idade = 17;

Pessoa2.Nome = "Joao";
Pessoa2.Idade = 16;


if (Pessoa1.Idade > Pessoa2.Idade)
{
    System.Console.WriteLine($"{Pessoa1.Nome} é mais velha!");
}
else
{
    System.Console.WriteLine($"{Pessoa2} é mais velha!");
}