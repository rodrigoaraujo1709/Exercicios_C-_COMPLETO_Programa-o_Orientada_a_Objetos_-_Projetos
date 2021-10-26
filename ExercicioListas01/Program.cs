using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioListas01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
            N funcionários. Não deve haver repetição de id.
            Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
            Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
            mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
            conforme exemplos.
            Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
            ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
            aumento por porcentagem dada.

             */

            Console.Write("How many employees will be registered? ");
            int employeeCount = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= employeeCount; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Salary: ");
                double salary = double.Parse(Console.ReadLine());


                list.Add(new Employee(id, name, salary));
            }

            foreach (Employee obj in list)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}
