using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMembrosEstaticos01
{
    class ConversorDeMoeda
    {
        public static double CotacaoDoDolar;
        public static double Iof = 0.06;

        public static string ConverterDolarParaReal(double dolar)
        {
            return ((dolar + dolar * Iof) * CotacaoDoDolar).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
