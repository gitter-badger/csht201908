using System;

namespace App04Konstant
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var h = new { navn = "Mikkel" };
                const int antalMdr = 12;

                string person1Navn = "Mathias";
                int person1Alder = 12;
                // int person1Køn = 1; // antag 1 = mand
                Køn person1Køn = Køn.Mand;
                Console.WriteLine($"{person1Navn} er en {person1Køn}");
                Console.WriteLine($"{person1Navn} er en {Convert.ToInt32(person1Køn)}");

                string person2Navn = "Lene";
                int person2Alder = 53;
                //int person2Køn = 0; // antag 0 = kvinde
                Køn person2Køn = Køn.Kvinde;

                DayOfWeek a = DayOfWeek.Thursday;
                Console.WriteLine(a == DayOfWeek.Monday);

                switch (a)
                {
                    case DayOfWeek.Friday:



                        break;
                    case DayOfWeek.Monday:


                        break;
                    case DayOfWeek.Saturday:


                        break;
                    case DayOfWeek.Sunday:
                        break;
                    case DayOfWeek.Thursday:
                        break;
                    case DayOfWeek.Tuesday:
                        break;
                    case DayOfWeek.Wednesday:
                        break;
                    default:
                        break;
                }

                Kulør k = Kulør.Klør;

                switch (k)
                {
                    case Kulør.Hjerter:
                        break;
                    case Kulør.Ruder:
                        break;
                    case Kulør.Spar:
                        break;
                    case Kulør.Klør:
                        break;
                    default:
                        break;
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("ÆLkælskdf");

                BilType b = BilType.PersonBil;
            }
            {

                double a = 4030.75;
                int b = System.Convert.ToInt32(a);  // 4.031
                string c = "100";
                int d = System.Convert.ToInt32(c);  // 100
                // forudsætter afvikling på en dansk maskine
                string e = "23,45";
                double f = System.Convert.ToDouble(e);  // 23.45
                string g = "2012-7-23";
                DateTime h = System.Convert.ToDateTime(g);  // 2012-07-23
                string i = "2019-8-1 15:35";
                DateTime j = System.Convert.ToDateTime(i);  // 2019-08-01 15:15


            }

            {

                string a = "434";
                int b = int.Parse(a);
                double c = double.Parse(a);

                bool f = true;
                if (f)
                {
                    Console.WriteLine("Sandt");
                }
                else
                {
                    Console.WriteLine("Falsk");
                }



                Console.WriteLine("*");

            }
            {

                string a = null;
                Console.WriteLine(a.ToUpper());     // fejl
                if (a != null)
                {
                    Console.WriteLine(a.ToUpper()); // ok
                }
            }

            {
                string a = null;
                Console.WriteLine(a?.ToUpper());
            }
            {
                string a = null;
                string b = a ?? "";
                Console.WriteLine(b.ToUpper());
            }
        }
    }


}
