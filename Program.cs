// See https://aka.ms/new-console-template for more information
using System.Globalization;
using OrientacaoObjetosC_;

Pessoa Pessoa1, Pessoa2, Pessoa3, Pessoa4;

// Pessoa1 = new Pessoa();
// Pessoa2 = new Pessoa();

// System.Console.Write("Digite o nome da primeira pessoa: ");
// Pessoa1.Nome = Console.ReadLine();
// System.Console.Write("Digite a idade da primeira pessoa: ");
// Pessoa1.Idade = int.Parse(Console.ReadLine());

// System.Console.Write("Digite o nome da segunda pessoa: ");
// Pessoa1.Nome = Console.ReadLine();
// Pessoa2.Nome = "Joao";
// System.Console.Write("Digite a idade da segunda pessoa: ");
// Pessoa2.Idade = int.Parse(Console.ReadLine());


// if (Pessoa1.Idade > Pessoa2.Idade)
// {
//     System.Console.WriteLine($"{Pessoa1.Nome} é mais velha!");
// }
// else
// {
//     System.Console.WriteLine($"{Pessoa2.Nome} é mais velha!");
// }

Pessoa3 = new Pessoa();
Pessoa4 = new Pessoa();

System.Console.WriteLine("Digite o nome da primeira pessoa: ");
Pessoa3.Nome = Console.ReadLine();
System.Console.WriteLine("Digite o salario da primeira pessoa: ");
Pessoa3.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


System.Console.WriteLine("Digite o nome da segunda pessoa: ");
Pessoa4.Nome = Console.ReadLine();
Pessoa4.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double media = (double)((Pessoa3.Salario + Pessoa4.Salario) / 2);

System.Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

