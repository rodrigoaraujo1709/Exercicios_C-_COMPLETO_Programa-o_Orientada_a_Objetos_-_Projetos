using System;
using System.Globalization;

namespace ExercicioSecaoCinco01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do 
            titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito 
            inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua 
            conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
            Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já 
            o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por 
            exemplo). 
            Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger 
            isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque 
            realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for 
            suficiente para realizar o saque e/ou pagar a taxa.
            Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não 
            informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre 
            mostrando os dados da conta após cada operação.
             */

            Console.Write("Digite o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite seu nome: ");
            string nomeTitular = Console.ReadLine();

            double saldo = 0.00;
            Console.Write("Haverá depósito inicial (s/n)?");
            char pergunta = char.Parse(Console.ReadLine());
            if(pergunta == 'S' || pergunta == 's')
            {
                Console.Write("Valor do depósito inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Conta conta01 = new Conta(numero, nomeTitular, saldo);
            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(conta01);



            Console.Write("\nEntre um valor para dépósito: ");
            conta01.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(conta01);

            Console.Write("\nEntre um valor para saque: ");
            conta01.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(conta01);


        }
    }
}
