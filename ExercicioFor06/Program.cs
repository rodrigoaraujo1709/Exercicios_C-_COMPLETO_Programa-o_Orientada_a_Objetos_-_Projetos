﻿using System;

namespace ExercicioFor06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ler um número inteiro N e calcular todos os seus divisores. 
             */
            Console.WriteLine("Digite um numero para saber seus divisores: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
