using System;

namespace testevetor
{
    class Program
    {
        static void Main(string[] args)
        {
            const int qntdDeQuartosDisponiveis = 9;

            Console.WriteLine("Qnts serão lidos? ");
            int qntd = int.Parse(Console.ReadLine());

            ClasseDeTEsteVetor[] Vet = new ClasseDeTEsteVetor[qntdDeQuartosDisponiveis];

            for (int i = 0; i <= qntdDeQuartosDisponiveis; i++)
            {
                Console.WriteLine("Id: ");
                Vet[i].Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome: ");
                Vet[i].Nome = Console.ReadLine();
            }

            for (int i = 0; i <= qntdDeQuartosDisponiveis; i++)
            {
                if (Vet[i].Id != null)
                {
                    Console.WriteLine(Vet[i].Id);
                    Console.WriteLine(Vet[i].Nome);
                }
            }



        }
    }
}
