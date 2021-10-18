using System;
using System.Globalization;

namespace ExercicioOO03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno01 = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno01.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno01.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno01.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno01.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = "
                + aluno01.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno01.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                    + aluno01.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS");
            }
        }
    }
}
