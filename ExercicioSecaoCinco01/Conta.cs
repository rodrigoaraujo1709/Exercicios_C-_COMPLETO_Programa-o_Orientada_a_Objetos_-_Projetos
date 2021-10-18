using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSecaoCinco01
{
    class Conta
    {
        private int Numero { get; }
        public string NomeTitular { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string nomeTitular)
        {
            Numero = numero;
            NomeTitular = nomeTitular;
        }

        public Conta(int numero, string nomeTitular, double depositoInicial)
        {
            Numero = numero;
            NomeTitular = nomeTitular;
            Deposito(depositoInicial);
        }       

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            if (valor > 0)
            {
                Saldo = Saldo - valor - 5;
            }
        }

        public override string ToString()
        {
            return "Conta " + Numero + 
                    ", Titular " + NomeTitular + 
                    ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
