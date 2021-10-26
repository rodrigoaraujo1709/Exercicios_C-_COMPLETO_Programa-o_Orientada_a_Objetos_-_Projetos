using System;
using System.Collections.Generic;
using TestesDeInicializacao;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vetorDeString;
            int[] vetorDeInt;

            string[] vetorDeStringIni = new string[9];
            int[] vetorDeIntIni = new int[9];

            string variavelString;
            int variavelInt;

            int variavelIntini = new int();
            double variavelDoubleini = new double();
            string variavelStringIni = new string("teste");

            Console.WriteLine("vetorDeString " + vetorDeStringIni[0]);
            Console.WriteLine("vetorDeIntIni " + vetorDeIntIni[0]);

            Console.WriteLine("variavelIntini " + variavelIntini);
            Console.WriteLine("variavelDoubleini " + variavelDoubleini);
            Console.WriteLine("variavelStringIni " + variavelStringIni);


            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //Console.WriteLine(x.Value);
            Console.WriteLine(y.Value);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X é nulo");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("y é nulo");

            double z = x ?? 999; //se x for nulo vai jogar no z 999

            Console.WriteLine(z);



            int result;
            Console.WriteLine(result = Calculator.Sum(10, 20, 30, 40));


            //modificadores de parametros ref e out
            int a = 10;
            Calculator.TripleZoado(a);
            Console.WriteLine(a); //será impresso o 10, pois o método Triple da classe Calculator, está usando variavel local
            

            //ref
            int b = 10;
            Calculator.Triple(ref b);
            Console.WriteLine(b);

            //out
            int c = 10;
            int triple;
            Calculator.TripleOut(a, out triple);
            Console.WriteLine(triple);

            //boxing e unboxing
            //boxing - processo de conversão de um objeto tupo valor para um objeto tipo referencia compativel
            int xx = 20;
            Object obj = xx;

            //unboxing - processo de covnersão de um objeto tipo referencia para um objeto tipo valor compativel
            int yy = (int)obj;

            //sintaxe opcional: laço foreach
            string[] vetc = new string[] { "Maria", "Alex", "Bob" };

            /* impressão do vetor com for
            for (int i = 0; i< vetc.Length; i++)
            {
                Console.WriteLine(vetc[i]);
            }
            */

            //agora com foreach
            foreach(string V in vetc)
            {
                Console.WriteLine(V);
            }


            //listas

            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string obj2 in list)
            {
                Console.WriteLine(obj2);
            }

            Console.WriteLine("List count: " + list.Count);


            //encontrando item especifico da lista usando função
            string s1 = list.Find(Test);
            Console.WriteLine("First 'A': " +s1);


            //encontrando item especifico da lista usando espressão lambda
            string s2 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s2);

            //ultima ocorrencia dos nomes com A
            string s3 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s3);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-----------------");
            foreach (string obj3 in list2)
            {
                Console.WriteLine(obj3);
            }

            list.Remove("Alex");
            Console.WriteLine("-----------------");
            foreach (string obj4 in list)
            {
                Console.WriteLine(obj4);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-----------------");
            foreach (string obj4 in list)
            {
                Console.WriteLine(obj4);
            }



            list.RemoveAt(1);
            Console.WriteLine("-----------------");
            foreach (string obj4 in list)
            {
                Console.WriteLine(obj4);
            }
            Console.WriteLine("-----------------");

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Anna");
            list.Insert(2, "Marco");
            foreach (string obj2 in list)
            {
                Console.WriteLine(obj2);
            }

            list.RemoveRange(1, 2);
            Console.WriteLine("-----------------");
            foreach (string obj4 in list)
            {
                Console.WriteLine(obj4);
            }

            double[,] mat = new double[2, 3];
            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));


        }


        //função para o list.Find localizar item com letra A
        static bool Test(string s)
        {
            return s[0] == 'A';
        }

                

    }
}
