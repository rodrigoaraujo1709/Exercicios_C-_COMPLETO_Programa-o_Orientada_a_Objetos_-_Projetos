using System;
using System.Globalization;

namespace ExerciciosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
             código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
             */

            int IDPeca1, IDPeca2, QntPecas1, QntPecas2;
            double ValorPeca1, ValorPeca2;

            //Adicionando informações do primeiro produto
            Console.WriteLine("Digite o código da peça 1: ");
            IDPeca1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade da peça 1: ");
            QntPecas1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da peça 1: ");
            ValorPeca1 = double.Parse(Console.ReadLine());

            //Adicionando informações do segundo produto
            Console.WriteLine("Digite o código da peça 2: ");
            IDPeca2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade da peça 2: ");
            QntPecas2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da peça 2: ");
            ValorPeca2 = double.Parse(Console.ReadLine());


            //Mostrando valor total a ser pago
            Console.WriteLine("VALOR A PAGAR: R$ " + ((QntPecas1 * ValorPeca1) + (QntPecas2 * ValorPeca2)).ToString("F2", CultureInfo.InvariantCulture) );



        }
    }
}
