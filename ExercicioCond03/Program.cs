using System;

namespace ExercicioCond03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
            Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
            ordem crescente ou decrescente.
             */
            Console.WriteLine("Digite 2 valores inteiros, para saber se são multiplos: ");
            string[] valores = Console.ReadLine().Split();

            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {

                Console.WriteLine("Não São Multiplos");
            }

        }
    }
}
