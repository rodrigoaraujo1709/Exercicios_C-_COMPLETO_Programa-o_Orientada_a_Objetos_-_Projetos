using ExercicioVetores01_04_Relembrando.Entities;
using System;

namespace ExercicioVetores01_04_Relembrando
{
    class Program
    {
        static void Main(string[] args)
        {
            const int qntdQuartos = 3;
            Quarto[] quartos = new Quarto[qntdQuartos];

            Console.Write("Quantos estudantes vão alugar quartos? ");
            int qntdEstudantes = int.Parse(Console.ReadLine());
            while (qntdEstudantes < 1 || qntdEstudantes > qntdQuartos)
            {
                Console.WriteLine("Digite um numero de 1 a " + qntdQuartos);
                qntdEstudantes = int.Parse(Console.ReadLine());
            }
            int nrQuarto;
            for (int i = 1; i <= qntdEstudantes; i++)
            {
                Console.Write("Digite o numero do quarto: ");
                nrQuarto = int.Parse(Console.ReadLine());
                while (nrQuarto < 1 || nrQuarto > qntdQuartos)
                {
                    Console.WriteLine("Digite um numero de 1 a " + qntdQuartos);
                    nrQuarto = int.Parse(Console.ReadLine());
                }

                Console.Write("Nome: ");
                string locatarioNome = Console.ReadLine();

                Console.Write("E-mail: ");
                string locatarioEmail = Console.ReadLine();

                quartos[nrQuarto] = new Quarto(locatarioNome, locatarioEmail);

            }







        }
    }
}
