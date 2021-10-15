using System;
using System.Globalization;

namespace ExercicioLogica02
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
             casas decimais.
             */

            double Raio;
            const double pi = 3.14159;

            Console.WriteLine("Digite o valor do raio do circulo: ");
            Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("A=" + (pi * (Raio * Raio)).ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
