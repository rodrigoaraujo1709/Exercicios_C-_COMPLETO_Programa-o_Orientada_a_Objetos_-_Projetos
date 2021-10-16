using System;
using System.Globalization;

namespace ExercicioFor03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste 
            de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes 
            conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem 
            peso 5.
             */

            double N1 = 0, N2 = 0, N3 = 0, MP = 0;
            const double P1 = 2, P2 = 3, P3 = 5;

            Console.Write("Digite quantos casos de testes deseja fazer: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite as 3 notas: ");
                string[] notas = Console.ReadLine().Split(" "); //VERIFICAR COMO RECEBER O VETOR COM O CULTUREINFO.INVARIANTCULTURE
                N1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
                N2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
                N3 = double.Parse(notas[2], CultureInfo.InvariantCulture);

                MP = (N1 * P1 + N2 * P2 + N3 * P3) / (P1 + P2 + P3);

                Console.WriteLine(MP.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
    }
}
