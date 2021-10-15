using System;

namespace ExercicioCond02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero inteiro para saber se é par ou impar: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
