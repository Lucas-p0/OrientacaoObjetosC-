using System;
using System.Globalization;
using OrientacaoObjetosC_;

Produto produto = new("tv", 900.00, 15);

Console.WriteLine("Entre com os dados do produto: ");
Console.Write("Nome: ");
string nome = Console.ReadLine();

Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine());

Console.Write("Quantidad de estoque: ");
int quantidade = int.Parse(Console.ReadLine());


Produto p = new(nome, preco, quantidade);
Produto.ValorTotalEmEstoque(preco, quantidade);





