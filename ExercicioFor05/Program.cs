using System;

namespace ExercicioFor05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1. 
            Lembrando que, por definição, fatorial de 0 é 1.
             */
            Console.Write("Digite um numero para calcular o fatorial");
            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= n; i++)
            {
                fat = fat * i;
            }

            Console.WriteLine(fat);
        }
    }
}
