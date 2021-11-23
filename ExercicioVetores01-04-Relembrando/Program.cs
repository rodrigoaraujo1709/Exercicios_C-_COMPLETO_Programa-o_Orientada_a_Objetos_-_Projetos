using ExercicioVetores01_04_Relembrando.Entities;
using System;

namespace ExercicioVetores01_04_Relembrando
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] quartos = new Quarto[9];

            Console.Write("Quantos estudantes vão alugar quartos? ");
            int QtdEstudantes = int.Parse(Console.ReadLine());
            while (QtdEstudantes < 1 || QtdEstudantes > 10)
            {
                Console.WriteLine("Digite um numero de 1 a 10");
                QtdEstudantes = int.Parse(Console.ReadLine());
            }
            int nrQuarto;
            for (int i = 1; i <= QtdEstudantes; i++)
            {
                Console.Write("Digite o numero do quarto: ");
                nrQuarto = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string locatarioNome = Console.ReadLine();

                Console.Write("E-mail: ");
                string locatarioEmail = Console.ReadLine();

                quartos[nrQuarto] = new Quarto(locatarioNome, locatarioEmail);

            }


            

        }
    }
}
