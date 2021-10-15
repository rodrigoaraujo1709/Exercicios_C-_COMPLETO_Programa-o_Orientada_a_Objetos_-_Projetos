using System;
using System.Globalization;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e 
            mostre:  
            a) a área do triângulo retângulo que tem A por base e C por altura.  
            b) a área do círculo de raio C. (pi = 3.14159)  
            c) a área do trapézio que tem A e B por bases e C por altura.  
            d) a área do quadrado que tem lado B.  
            e) a área do retângulo que tem lados A e B.
             */

            double A, B, C;
            const double Pi = 3.14159; 

            Console.WriteLine("Valor A: ");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor B: ");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor C: ");
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("TRIANGULO: " + (A * C / 2).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + (Pi * Math.Pow(C,2)).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: " + ((A + B) / 2 * C).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + (B * B).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + (A * B).ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
