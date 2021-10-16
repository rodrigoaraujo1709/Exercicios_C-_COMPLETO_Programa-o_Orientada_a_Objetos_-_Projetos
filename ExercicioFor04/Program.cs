using System;
using System.Globalization;

namespace ExercicioFor04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo 
            segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel". 
             */
            Console.Write("Digite quantas divisões deseja fazer: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.Write("Digite os numeros que deseja dividir: ");
                string[] numeros = Console.ReadLine().Split();
                double D1 = double.Parse(numeros[0], CultureInfo.InvariantCulture);
                double D2 = double.Parse(numeros[1], CultureInfo.InvariantCulture);

                if (D2 == 0)
                {
                    Console.WriteLine("Divisão impossivel");
                }
                else
                {
                    Console.WriteLine((D1/D2).ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
