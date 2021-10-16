﻿using System;

namespace ExercicioFor02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. 
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
            essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
             */
            int In = 0, Out = 0;

            Console.WriteLine("Quantos numeros vai querer digitar: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite um valor: ");
                double X = double.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20)
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
