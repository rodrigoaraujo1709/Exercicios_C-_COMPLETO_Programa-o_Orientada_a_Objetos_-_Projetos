using System;
using System.Globalization;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
    hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
    decimais.
             */
            int nr, hr;
            double valHr, sal;

            Console.WriteLine("Numero do funcionario: ");
            nr = int.Parse(Console.ReadLine());
            Console.WriteLine("Horas trabalhadas: ");
            hr = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor por hora: ");
            valHr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            sal = valHr * hr;
            Console.WriteLine("NUMBER = " + nr);
            Console.WriteLine("SALARY = U$ " + sal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
