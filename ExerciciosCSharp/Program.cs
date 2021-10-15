using System;
using System.Globalization;

namespace ExerciciosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
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
