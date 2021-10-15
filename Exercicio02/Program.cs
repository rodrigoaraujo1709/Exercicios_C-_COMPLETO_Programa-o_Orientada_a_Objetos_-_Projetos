using System;
using System.Globalization;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
            casas decimais conforme exemplos.
             */
            double Raio, Area;
            const double pi = 3.14159;

            Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = pi * Math.Pow(Raio,2);

            Console.WriteLine("A=" + Area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
