// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Solicita a quantidade de produtos em estoque
        Console.Write("Informe a quantidade de produtos em estoque: ");

        // Tenta converter a entrada do usuário para um número inteiro
        if (int.TryParse(Console.ReadLine(), out int quantidadeEmEstoque))
        {
            // Solicita o preço unitário dos produtos em estoque
            Console.Write("Informe o preço unitário dos produtos em estoque: ");

            // Tenta converter a entrada do usuário para um número decimal (preço unitário)
            if (decimal.TryParse(Console.ReadLine(), out decimal precoUnitario))
            {
                // Calcula o valor total em estoque
                decimal valorTotalEmEstoque = quantidadeEmEstoque * precoUnitario;

                // Exibe a quantidade de produtos em estoque e o valor total
                Console.WriteLine($"A quantidade de produtos em estoque é: {quantidadeEmEstoque}");
                Console.WriteLine($"O preço unitário dos produtos em estoque é: {precoUnitario:C}");
                Console.WriteLine($"O valor total em estoque é: {valorTotalEmEstoque:C}");
            }
            else
            {
                // Exibe uma mensagem de erro se a entrada não for um número decimal válido
                Console.WriteLine("Por favor, insira um preço unitário válido.");
            }
        }
        else
        {
            // Exibe uma mensagem de erro se a entrada da quantidade não for um número inteiro válido
            Console.WriteLine("Por favor, insira uma quantidade válida.");
        }
    }
}