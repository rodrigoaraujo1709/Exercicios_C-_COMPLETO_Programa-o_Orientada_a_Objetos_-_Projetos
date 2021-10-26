using System;

namespace ExercicioVetores01_Refeito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos serão alugados? ");
            int qntdQuartosAlugados = int.Parse(Console.ReadLine());

            Quarto[] quartos = new Quarto[9];

            for (int i = 1; i <= qntdQuartosAlugados; i++)
            {

                Console.WriteLine("Aluguel #" + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                quartos[quarto] = new Quarto(nome, email);
            }

            Console.WriteLine("Quartos ocupados: ");

            for (int i = 0; i < 9; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(i + ": " + quartos[i].NomeEstudante + ", " + quartos[i].EmailEstudante);
                }
            }
        }
    }
}
