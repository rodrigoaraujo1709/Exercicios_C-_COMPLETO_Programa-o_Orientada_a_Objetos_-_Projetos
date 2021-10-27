using System;
using System.Globalization;

namespace RascunhoSecao07
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var y = 22.2;
            var z = "Rodrigo";
            Console.WriteLine(a);
            Console.WriteLine(y);
            Console.WriteLine(z);

            //--------------------------------------------------

            int x = int.Parse(Console.ReadLine());
            string day;
            if (x == 1)
            {
                day = "Sunday";
            }
            else if (x == 2)
            {
                day = "Monday";
            }
            else if (x == 3)
            {
                day = "Tuesday";
            }
            else if (x == 4)
            {
                day = "Wednesday";
            }
            else if (x == 5)
            {
                day = "Thursday";
            }
            else if (x == 6)
            {
                day = "Friday";
            }
            else if (x == 7)
            {
                day = "Saturday";
            }
            else
            {
                day = "Invalid value";
            }
            Console.WriteLine("Day: " + day);

            //switch-case

            int b = int.Parse(Console.ReadLine());
            string day2;
            switch (b)
            {
                case 1:
                    day2 = "Sunday";
                    break;
                case 2:
                    day2 = "Monday";
                    break;
                case 3:
                    day2 = "Tuesday";
                    break;
                case 4:
                    day2 = "Wednesday";
                    break;
                case 5:
                    day2 = "Thursday";
                    break;
                case 6:
                    day2 = "Friday";
                    break;
                case 7:
                    day2 = "Saturday";
                    break;
                default:
                    day2 = "Invalid value";
                    break;
            }
            Console.WriteLine("Day: " + day2);

            //-------------------------------------

            double preco = 34.5;
            double desconto;
            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }

            //Expressão condicional ternária

            double preco2 = 34.5;
            double desconto2 = (preco2 < 20.0) ? preco2 * 0.1 : preco2 * 0.05;

            //-------------------------------------
            //Funções interessantes para string
            /*
             Checklist
            • Formatar: ToLower(), ToUpper(), Trim()
            • Buscar: IndexOf, LastIndexOf
            • Recortar: Substring(inicio), Substring(inicio, tamanho)
            • Substituir: Replace(char, char), Replace(string, string)
            • String.IsNullOrEmpty(str), String.IsNullOrWhiteSpace(str)
            • str.Split(' ')
            • Conversão para numero: int x = int.Parse(str), int x =Convert.ToInt32(str)
            • Conversão de número: str = x.ToString(), str = x.ToString("C"), str =
            x.ToString("C3"), str = x.ToString("F2")
             */

            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);

            //DateTime

            DateTime d1 = new DateTime(2000, 8, 15);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            DateTime d11 = DateTime.Now;
            DateTime d22 = DateTime.UtcNow;
            DateTime d33 = DateTime.Today;
            Console.WriteLine(d11);
            Console.WriteLine(d22);
            Console.WriteLine(d33);

            DateTime d111 = DateTime.Parse("2000-08-15");
            DateTime d222 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d333 = DateTime.Parse("15/08/2000");
            DateTime d444 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d111);
            Console.WriteLine(d222);
            Console.WriteLine(d333);
            Console.WriteLine(d444);


            //determinar o proprio formato de data
            DateTime d1111 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d2222 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d1111);
            Console.WriteLine(d2222);

            //TimeSpan

            /*
             Construtores
            • TimeSpan()
            • TimeSpan(ticks)
            • TimeSpan(horas, minutos, segundos)
            • TimeSpan(dias, horas, minutos, segundos)
            • TimeSpan(dias, horas, minutos, segundos, milissegundos)
             */

            TimeSpan t11 = new TimeSpan();
            TimeSpan t22 = new TimeSpan(900000000L);
            TimeSpan t33 = new TimeSpan(2, 11, 21);
            TimeSpan t44 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t55 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t11);
            Console.WriteLine(t22);
            Console.WriteLine(t33);
            Console.WriteLine(t44);
            Console.WriteLine(t55);

            TimeSpan t1 = TimeSpan.FromDays(1.5);
            TimeSpan t2 = TimeSpan.FromHours(1.5);
            TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t6 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

            //Propriedades e Operações com DateTime

            /*
             Propriedades
            • Date (DateTime)
            • Day (int)
            • DayOfWeek (DayOfWeek)
            • DayOfYear (int)
            • Hour (int)
            • Kind (DateTimeKind)
            • Millisecond (int)
            • Minute (int)
            • Month (int)
            • Second (int)
            • Ticks (long)
            • TimeOfDay (TimeSpan)
            • Year (int)
             */

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            //Formatação (DateTime -> string)
            DateTime dd = new DateTime(2001, 8, 15, 13, 45, 58);
            string s11 = d.ToLongDateString();
            string s22 = d.ToLongTimeString();
            string s33 = d.ToShortDateString();
            string s44 = d.ToShortTimeString();
            string s55 = d.ToString();
            string s66 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s77 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s11);
            Console.WriteLine(s22);
            Console.WriteLine(s33);
            Console.WriteLine(s44);
            Console.WriteLine(s55);
            Console.WriteLine(s66);
            Console.WriteLine(s77);

            //Operações com Datetime
            /*
            DateTime ddd = new DateTime(2001, 8, 15, 13, 45, 58);
            DateTime yyy = ddd.Add(timeSpan);
            DateTime yyyy = ddd.AddDays(double);
            DateTime yyyyy = ddd.AddHours(double);
            DateTime yyyyyy = ddd.AddMilliseconds(double);
            DateTime yyyyyyy = ddd.AddMinutes(double);
            DateTime zz = ddd.AddMonths(int);
            DateTime zzz = ddd.AddSeconds(double);
            DateTime zzzz = ddd.AddTicks(long);
            DateTime zzzzz = ddd.AddYears(int);
            DateTime zzzzzz = ddd.Subtract(timeSpan);
            TimeSpan t = ddd.Subtract(dateTime);
            */

            //Propriedades e Operações com TimeSpan
            TimeSpan t111 = TimeSpan.MaxValue;
            TimeSpan t222 = TimeSpan.MinValue;
            TimeSpan t333 = TimeSpan.Zero;
            Console.WriteLine(t111);
            Console.WriteLine(t222);
            Console.WriteLine(t333);

            //propriedades
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            //operações
            TimeSpan t1111 = new TimeSpan(1, 30, 10);
            TimeSpan t2222 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t1111.Add(t2222);
            TimeSpan dif = t1111.Subtract(t2222);
            TimeSpan mult = t2222.Multiply(2.0);
            TimeSpan div = t2222.Divide(2.0);
            Console.WriteLine(t1111);
            Console.WriteLine(t2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);

            //DateTimeKind e padrão ISO 8601
            DateTime d13 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d23 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d32 = new DateTime(2000, 8, 15, 13, 5, 58);
            Console.WriteLine("d1: " + d13);
            Console.WriteLine("d1 Kind: " + d13.Kind);
            Console.WriteLine("d1 to Local: " + d13.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d13.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d23);
            Console.WriteLine("d2 Kind: " + d23.Kind);
            Console.WriteLine("d2 to Local: " + d23.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d23.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d3: " + d32);
            Console.WriteLine("d3 Kind: " + d32.Kind);
            Console.WriteLine("d3 to Local: " + d32.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d32.ToUniversalTime());

            //Padrão ISO 8601

            DateTime d19 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d29 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
            Console.WriteLine("d1: " + d19);
            Console.WriteLine("d1 Kind: " + d19.Kind);
            Console.WriteLine("d1 to Local: " + d19.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d19.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d29);
            Console.WriteLine("d2 Kind: " + d29.Kind);
            Console.WriteLine("d2 to Local: " + d29.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d29.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d29.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(d29.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));

        }
    }
}
