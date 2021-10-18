using System;
using System.Globalization;

namespace ExercicioOO02
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario func01 = new Funcionario();

            Console.Write("Nome: ");
            func01.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            func01.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            func01.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario :" + func01.Nome + ", $ " + func01.SalarioLiquido());

            Console.Write("Porcentagem de aumento: ");
            func01.AumentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine(func01);
        }
    }
}
