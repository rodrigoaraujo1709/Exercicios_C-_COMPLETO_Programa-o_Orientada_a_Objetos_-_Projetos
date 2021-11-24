using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetores01_04_Relembrando.Entities
{
    class Quarto
    {
        public string LocatarioNome { get; private set; }
        public string LocatarioEmail { get; private set; }

        public Quarto(string locatarioNome, string locatarioEmail)
        {
            LocatarioNome = locatarioNome;
            LocatarioEmail = locatarioEmail;
        }

        


    }
}
