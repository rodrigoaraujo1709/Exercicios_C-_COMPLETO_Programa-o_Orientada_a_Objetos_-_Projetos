using System;
using System.Globalization;

namespace Consulta02Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            Produto p = new Produto(nome, preco, quantidade);


            /*
             OUTRA FORMA PARA INSTANCIAR UM OBJETO MESMO SE A CLASSE NÃO POSSUIR CONTRUTOR IMPLEMENTADO

                Produto p = new Produto {
                Nome = "TV",
                Preco = 900.0,
                Quantidade = 0
                };
                Produto p2 = new Produto() {
                Nome = "TV",
                Preco = 900.0,
                Quantidade = 0
                };

             */


            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
