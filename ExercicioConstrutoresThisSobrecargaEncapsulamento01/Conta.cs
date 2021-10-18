using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Conta
    {
        private int Nr { get; }
        public string NomeTitular  { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int nr, string titular, double saldo)
        {
            Nr = nr;
            NomeTitular = titular;
            Saldo = saldo;
        }
        public Conta(int nr, string titular)
        {
            Nr = nr;
            NomeTitular = titular;
            Saldo = 0.0;
        }

        void Sacar()
        {

        }

        void Depositar()
        {

        }
    }
}
