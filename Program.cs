// See https://aka.ms/new-console-template for more information
// using System.Globalization;
// using OrientacaoObjetosC_;

// Pessoa Pessoa1, Pessoa2, Pessoa3, Pessoa4;

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

// Pessoa3 = new Pessoa();
// Pessoa4 = new Pessoa();

// System.Console.WriteLine("Digite o nome da primeira pessoa: ");
// Pessoa3.Nome = Console.ReadLine();
// System.Console.WriteLine("Digite o salario da primeira pessoa: ");
// Pessoa3.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


// System.Console.WriteLine("Digite o nome da segunda pessoa: ");
// Pessoa4.Nome = Console.ReadLine();
// string PessoaNome = Pessoa4.Nome;
// Pessoa4.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// double media = (double)((Pessoa3.Salario + Pessoa4.Salario) / 2);

// System.Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));





// static double? Media(int salario, int n)
// {

// System.Console.Write("Digite a quantidade de pessoa: ");
// int n = int.Parse(Console.ReadLine());
// double media = 0;
// for (int i = 1; i <= n; i++)
// {
//     System.Console.Write($"Digite o nome da {i}ª Pessoa :");
//     string? nome = Console.ReadLine();
//     System.Console.Write($"Digite o salario da {i}ª pessoa: ");
//     double? salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//     salario += salario;
//     media = (double)(salario / n);
// }
// System.Console.WriteLine($"Média salarial das {n} pessoas é : {media}");
// double mediaResultado = soma / n;
// return mediaResultado;
// }

using System.Globalization;
using OrientacaoObjetosC_;

// Triangulo x, y;

// x = new Triangulo();


// System.Console.Write("Digite o tamanho do primeiro lado:");
// x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// System.Console.Write("Digite o tamanho do segundo lado:");
// x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// System.Console.Write("Digite o tamanho do terceiro lado:");
// x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



// double areaX = x.Area();

// System.Console.WriteLine(areaX.ToString("F2", CultureInfo.InvariantCulture));
Produto P = new();
Console.WriteLine("Entre com os dados do produto: ");

Console.Write("Nome do produto: ");
P.Nome = Console.ReadLine();

Console.Write("Preço: ");
P.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantidade: ");
P.Quantidade = int.Parse(Console.ReadLine());



double somaProduto1 = P.ValorTotalEmEstoque();
Console.WriteLine($"Valor total em estoque: {P}");

System.Console.Write($"\nDigite o número de produtos a ser adicionado");
int qte = int.Parse(Console.ReadLine());


P.AdicionaQuantidade(qte);
Console.WriteLine($"Valor total em estoque: {P}");
