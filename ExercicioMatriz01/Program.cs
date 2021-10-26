using System;

namespace ExercicioMatriz01
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Fazer um programa para ler um número inteiro N e uma matriz de
            ordem N contendo números inteiros. Em seguida, mostrar a diagonal
            principal e a quantidade de valores negativos da matriz.
             */
            Console.WriteLine("Ordem da matriz: ");
            int lenghtMatrix = int.Parse(Console.ReadLine());

            double[,] mat = new double[lenghtMatrix, lenghtMatrix];


            for (int i = 0; i < lenghtMatrix; i++)
            {
                string[] vet = Console.ReadLine().Split(" ");
                for (int j = 0; j < lenghtMatrix; j++)
                {
                    mat[i, j] = double.Parse(vet[j]);
                }
            }

            for (int i = 0; i < lenghtMatrix; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < lenghtMatrix; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
            }

            Console.WriteLine("\nMain diagonal: ");
            for (int i = 0; i < lenghtMatrix; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < lenghtMatrix; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(mat[i, j]);
                    }
                }
            }

            Console.WriteLine("\nNegative number: ");
            int negativesCount = 0;
            for (int i = 0; i < lenghtMatrix; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < lenghtMatrix; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        Console.WriteLine(mat[i, j]);
                        negativesCount++;
                    }
                }
            }
            Console.WriteLine(negativesCount);
        }
    }
}
