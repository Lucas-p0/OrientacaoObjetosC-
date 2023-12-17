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

// using System.Globalization;
// using OrientacaoObjetosC_;

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
// void mensagemDeBoasVindas()
// {
//     Console.Clear();
//     string mensagem = @"
// ██╗    ██╗███╗   ███╗███████╗
// ██║    ██║████╗ ████║██╔════╝
// ██║ █╗ ██║██╔████╔██║███████╗
// ██║███╗██║██║╚██╔╝██║╚════██║
// ╚███╔███╔╝██║ ╚═╝ ██║███████║
//  ╚══╝╚══╝ ╚═╝     ╚═╝╚══════╝
//                              ";
//     System.Console.WriteLine(mensagem);
// };
// void ExibeOpcoesDeMenu()
// {
//     Console.Clear();
//     mensagemDeBoasVindas();
//     Console.WriteLine($"\nDigite 1 para registrar um produto: ");
//     Console.WriteLine($"Digite 2 para aumentar a quantidade de produto: ");
//     Console.WriteLine($"Digite 3 para retirar uma determinada quantidade de um produto: ");
//     Console.WriteLine($"Digite 0 para sair: ");

//     Console.WriteLine("Digite sua opção:");
//     int opcaoEscolhida = int.Parse(Console.ReadLine());


//     switch (opcaoEscolhida)
//     {
//         Produto produto = new()
//         case 1:
//             Produto.ValorTotalEmEstoque();
//             break;
//         case 2:
//             Produto.AdicionaQuantidade();
//             break;
//         case 3:
//             Produto.RemoverQuantidade();
//             break;
//         case 0:
//             Produto.ValorTotalEmEstoque();
//             break;
//     }
// }
// Produto P = new();
// Console.WriteLine("Entre com os dados do produto: ");

// Console.Write("Nome do produto: ");
// P.Nome = Console.ReadLine();

// Console.Write("Preço: ");
// P.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// Console.Write("Quantidade: ");
// P.Quantidade = int.Parse(Console.ReadLine());



// double somaProduto1 = P.ValorTotalEmEstoque();
// Console.WriteLine($"Valor total em estoque: {P}");

// System.Console.Write($"\nDigite o número de produtos a ser adicionado");
// int qte = int.Parse(Console.ReadLine());


// P.AdicionaQuantidade(qte);
// Console.WriteLine($"Valor total em estoque: {P}");

using System.Globalization;
using OrientacaoObjetosC_;

// Retangulo retangulo = new();

// System.Console.Write("Digite a Altura do retangulo: ");
// retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// System.Console.Write("Digite a largura do retangulo:");
// retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


// double retanguloetanguloArea = retangulo.RetanguloArea();
// double retanguloPerimetro = retangulo.RetanguloPerimetro();
// double retanguloDiagonal = retangulo.RetanguloDiagonal();

// System.Console.WriteLine($"\nÁREA = {retanguloetanguloArea.ToString("F2", CultureInfo.InvariantCulture)}");
// System.Console.WriteLine($"PÉRIMETRO = {retanguloPerimetro.ToString("F2", CultureInfo.InvariantCulture)}");
// System.Console.WriteLine($"DIAGONAL = {retanguloDiagonal.ToString("F2", CultureInfo.InvariantCulture)}");
// Funcionario funcionario = new();

// Console.Write("Digite o nome do colaborador: ");
// funcionario.Nome = Console.ReadLine();

// Console.Write("Digite o salario do colaborador: ");
// #pragma warning disable CS8604 // Possível argumento de referência nula.
// funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// #pragma warning restore CS8604 // Possível argumento de referência nula.

// Console.Write("Digite os descontos do colaborador: ");
// #pragma warning disable CS8604 // Possível argumento de referência nula.
// funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// #pragma warning restore CS8604 // Possível argumento de referência nula.

// double salarioLiquido = funcionario.SalarioLiquido();

// System.Console.Write("Digite a porcentagem para aumentar o salário: ");
// #pragma warning disable CS8604 // Possível argumento de referência nula.
// double porcentagem = double.Parse(Console.ReadLine());
// #pragma warning restore CS8604 // Possível argumento de referência nula.

// double aumentarSalario = funcionario.AumentarSalario(porcentagem);

// System.Console.WriteLine($"Dados atualizados: {aumentarSalario}");

Aluno aluno = new();

Console.Write("Digite o nome do aluno: ");
aluno.Nome = Console.ReadLine();

Console.Write("Digite a primeira nota do aluno: ");
aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Digite a segunda nota do aluno: ");
aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Digite a terceira nota do aluno: ");
aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double mediaAluno = aluno.Media();

Console.Write($"{mediaAluno.ToString("F2", CultureInfo.InvariantCulture)}");

