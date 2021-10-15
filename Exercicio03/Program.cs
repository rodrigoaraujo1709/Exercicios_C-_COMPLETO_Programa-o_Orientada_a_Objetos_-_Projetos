using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
            de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D)
             */
            int A, B, C, D, dif;
            Console.WriteLine("Digite o primeiro numero: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto numero: ");
            D = int.Parse(Console.ReadLine());
            dif = A * B - C * D;
            Console.WriteLine("DIFERENCA = " + dif);
        }
    }
}
