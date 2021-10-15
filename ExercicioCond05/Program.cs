using System;
using System.Globalization;

namespace ExercicioCond05
{
    class Program
    {
        /*
         Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
        seguir, calcule e mostre o valor da conta a pagar.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("CÓDIGO |  ESPECIFICAÇÃO  |  PREÇO ");
            Console.WriteLine("  1    | CACHORRO QUENTE | R$ 4.00");
            Console.WriteLine("  2    |    X-SALADA     | R$ 4.50");
            Console.WriteLine("  3    |    X-BACON      | R$ 5.00");
            Console.WriteLine("  4    | TORRADA SIMPLES | R$ 2.00");
            Console.WriteLine("  5    |  REFRIGERANTE   | R$ 1.50");

            int IDProd, QntdProd;

            Console.WriteLine("Digite o código do produto: ");
            IDProd = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade: ");
            QntdProd = int.Parse(Console.ReadLine());

            if (IDProd == 1)
            {
                Console.WriteLine("Total: R$ " + (QntdProd * 4).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (IDProd == 2)
            {
                Console.WriteLine("Total: R$ " + (QntdProd * 4.5).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (IDProd == 3)
            {
                Console.WriteLine("Total: R$ " + (QntdProd * 5).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (IDProd == 4)
            {
                Console.WriteLine("Total: R$ " + (QntdProd * 2).ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Total: R$ " + (QntdProd * 1.5).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
