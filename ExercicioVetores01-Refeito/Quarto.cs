using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetores01_Refeito
{
    class Quarto
    {
        public string NomeEstudante { get; private set; }
        public string EmailEstudante { get; private set; }

        public Quarto(string nomeEstudante, string emailEstudante)
        {
            NomeEstudante = nomeEstudante;
            EmailEstudante = emailEstudante;
        }
    }
}
