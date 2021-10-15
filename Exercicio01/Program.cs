using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
            mensagem explicativa, conforme exemplos.
             */
            Console.WriteLine("Digite dois valores inteiros para somar: ");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int Soma = A + B;
            Console.WriteLine("SOMA = " + Soma);
        }
    }
}
