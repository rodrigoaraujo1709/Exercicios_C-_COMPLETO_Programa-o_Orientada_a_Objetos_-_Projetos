using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDeInicializacao
{
    class Calculator
    {
        public static int Sum(params int[] numbers)
        {

            //metódo da classe calculadora - para calcular numeros passados no vetor de string
            int sum = 0;
            for (int i = 0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }


        //metódo da classe calculadora - para calcular o triplo do numero passado
        //(forma errada pois a variavel de escopo local não vai ser retornada para o programa principal)
        public static void TripleZoado(int x)
        {
            x = x * 3;
        }

        //forma correta com ref
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        //forma correta com out
        public static void TripleOut(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
