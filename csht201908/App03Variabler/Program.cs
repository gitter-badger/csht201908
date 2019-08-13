using System;

namespace App03Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                DateTime a = DateTime.Now;
                a = new DateTime(2019, 8, 1, 10, 15, 30);
                Console.WriteLine(a);
                a = a.AddDays(-10);
                Console.WriteLine(a);

                Console.WriteLine(a.Year);

                Console.WriteLine($"Ugedag {a.DayOfWeek.ToString()}");
                Console.WriteLine($"Lille dato streng {a.ToShortDateString()}");
                Console.WriteLine($"Stor dato streng {a.ToLongDateString()}");
                Console.WriteLine($"Lille tid streng {a.ToShortTimeString()}");
                Console.WriteLine($"Stor tid streng {a.ToLongTimeString()}");

                string b = "2019-8-13";
                DateTime c = Convert.ToDateTime(b);
                DateTime d = new DateTime(2019, 9, 1, 15, 41, 0);
                TimeSpan e = d.Subtract(c);

            }

            {
                string a = "abc";
                a = a.ToUpper();
                Console.WriteLine(a.EndsWith("C"));

                string b = "abv\r\njsdkf";
                Console.WriteLine(b);

                string c = "c:\\temp\\test.txt";
                Console.WriteLine(c);

            }

            {
                string a = "Mikkel";
                string b = "Cronberg";
                string navn = "Navnet er : " + a + " " + b;
                Console.WriteLine(navn);

                string navn2 = $"Navnet er : {a} {b}";
                Console.WriteLine(navn2);

                double tal = 9345.434;
                string e = $"Tallet er {tal:N2}";
                Console.WriteLine(e);

                string f = null;
                if (f == null)
                {
                    Console.WriteLine("Kan ikke....");
                }
                else {
                    Console.WriteLine(f.ToUpper());
                }
                string g;
                




            }

            {
                // Stopur
                System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
                s.Start();
                string a = "";
                for (int i = 0; i < 50_000; i++)
                {
                    a = a + "*";
                }
                s.Stop();
                Console.WriteLine($"ms = {s.ElapsedMilliseconds}");
            }

            {
                System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                s.Start();
                for (int i = 0; i < 100_000_000; i++)
                {
                    sb.Append("*");
                }
                s.Stop();
                Console.WriteLine($"ms = {s.ElapsedMilliseconds}");
            }
            

        }

        
    }
}
