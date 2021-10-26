using System;

namespace ExercicioMatriz02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas linhas? ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas colunas? ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m,n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mat[i, m] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite um numero pertecente a matriz: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(mat[i, m]);
                }
            }
            /*
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, m] == x)
                    {
                        Console.WriteLine("Position: " + i + "," + j);
                        Console.WriteLine("Left: " + mat[i - 1, m]);
                        Console.WriteLine("Right: " + mat[i + 1, m]);
                        Console.WriteLine("Up: " + mat[i, m - 1]);
                        Console.WriteLine("Down: " + mat[i, m + 1]);
                    }
                }
            }*/

        }
    }
}
