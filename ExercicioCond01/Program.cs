using System;

namespace ExercicioCond01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não. 
             */
            
            Console.Write("Digite um numero inteiro para saber se é positivo ou negativo: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }
        }
    }
}
