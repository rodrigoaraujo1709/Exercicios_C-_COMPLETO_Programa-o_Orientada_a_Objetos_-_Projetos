using System;

namespace ExercicioCond04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
            começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
             */
            Console.Write("Hora inicial: ");
            int hrIni = int.Parse(Console.ReadLine());

            Console.Write("Hora final: ");
            int hrFin = int.Parse(Console.ReadLine());

            const int dia = 24;

            if (hrIni < hrFin)
            {
                Console.WriteLine(hrFin - hrIni); 
            }
            else
            {
                Console.WriteLine(dia - hrIni + hrFin);
            }
        }
    }
}
