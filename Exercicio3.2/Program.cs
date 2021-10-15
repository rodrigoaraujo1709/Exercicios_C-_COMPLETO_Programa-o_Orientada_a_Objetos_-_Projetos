using System;

namespace Exercicio3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int In = 0, Out = 0;

            Console.WriteLine("Quantos numeros vai querer digitar: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite um valor: ");
                double X = double.Parse(Console.ReadLine());
                if(X >= 10 && X <= 20)
                {
                    In++;
                }
                else
                {
                    Out++;
                }
            }
            Console.WriteLine(In + " in");
            Console.WriteLine(Out + " Out");
        }
    }
}
