using System;
using System.Globalization;
using OrientacaoObjetosC_;

Produto produto = new("tv", 900.00, 15);

Console.WriteLine("Entre com os dados do produto: ");
Console.Write("Nome: ");
string nome = Console.ReadLine();

Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantidad de estoque: ");
int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Produto p = new(nome, preco, quantidade);
var result = Produto.ValorTotalEmEstoque(preco, quantidade);

System.Console.WriteLine(result);

Produto p2 = new(nome, preco, quantidade)
{
    Nome = "tv",
    Preco = 32.00,
    Quantidade = 3

};



