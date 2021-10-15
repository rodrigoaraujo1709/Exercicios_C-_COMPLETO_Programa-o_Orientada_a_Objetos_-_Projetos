using System;
using System.Globalization;

namespace Exercicio2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau. Em seguida,  mostrar  os  valores  das  raízes  da  equação,  conforme  exemplos,  usando  a  fórmula  de  Baskara  (veja 
            abaixo).  Se  a  equação  não  possuir  raízes  (o  valor  de  "a"  não  pode  ser  zero,  e  o  valor  de  "delta"  não  pode  ser 
            negativo), mostrar uma mensagem "Impossivel calcular". 
             */
            Console.Write("Digite os 3 coeficientes da equação: ");
            /*string[] coeficientes = Console.ReadLine().Split(" ");

            double A = double.Parse(coeficientes[0], CultureInfo.InvariantCulture);
            double B = double.Parse(coeficientes[1], CultureInfo.InvariantCulture);
            double C = double.Parse(coeficientes[2], CultureInfo.InvariantCulture);*/

            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Delta = Math.Pow(B,2) - (4 * A * C);
            
            if (A == 0 || Delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double X1 = (-B + Math.Sqrt(Delta)) / 2 * A;
                double X2 = (-B - Math.Sqrt(Delta)) / 2 * A;
                Console.WriteLine(Delta);
                Console.WriteLine(X1);
                Console.WriteLine(X2);

            }
            

        }
    }
}
