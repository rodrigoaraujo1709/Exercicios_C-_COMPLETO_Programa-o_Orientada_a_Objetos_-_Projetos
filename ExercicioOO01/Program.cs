using System;
using System.Globalization;

namespace ExercicioOO01
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Fazer  um  programa  para  ler  os  valores  da  largura  e  altura  de  um  retângulo.  Em 
            seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe 
            como mostrado no projeto ao lado.
             */

            Retangulo ret01 = new Retangulo();

            Console.Write("Largura: ");
            ret01.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Altura: ");
            ret01.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(ret01);

        }
    }
}
