using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetores01_04_Relembrando.Entities
{
    class Quarto
    {
        private int NrQuarto { get; set; }
        private string LocatarioNome { get; set; }
        private string LocatarioEmail { get; set; }

        public Quarto(int nrQuarto, string locatarioNome, string locatarioEmail)
        {
            NrQuarto = nrQuarto;
            LocatarioNome = locatarioNome;
            LocatarioEmail = locatarioEmail;
        }


    }
}
