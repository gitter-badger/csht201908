using System;

namespace App02Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                
                //System.Byte a = 1;
                //System.Byte a = new System.Byte();
                int a = 1;
                a++;
                Console.WriteLine(a);
                byte b = 1;

                //int c = 1000;
                var c = 1000;
                string d = "";
                double e = 44.343;
                string f = "ædlfgælfd";

                e = e * 2;
            }

            {

                int a = 1;
                {
                    int b = 2;
                    a = 4;
                    {
                        
                    }
                }
                {
                    
                    int c = 3;
                    a = 400;
                }



            }

            {

                int a = 1;
                Console.WriteLine(a.ToString());

                Console.WriteLine(int.MaxValue);


                DateTime b = DateTime.Now;
                Console.WriteLine(b.AddDays(14));

                Console.WriteLine(DateTime.IsLeapYear(2019));

                
                


            }
            {

                for (int i = 0; i < 10; i++)
                {

                }

                int y = 1_000_000_000;

                float a;

                // eksempler: 
                a = 0.0000087f;

                int f = 1;
                f++;
                if (f    == 1)
                {
                    Console.WriteLine($"f = 1");
                }



            }

            //{
            //    byte a = 255;
            //    Console.WriteLine(a);
            //    a++;
            //    a++;
            //    a++;
            //    a++;
            //    a++;
            //    Console.WriteLine(a);
            //}

            //{
            //    byte a = 255;
            //    checked {
            //        a++;
            //    }
            //}

            {

                double a = 100202.354;
                Console.WriteLine(a);
                Console.WriteLine(a.ToString());
                Console.WriteLine(a.ToString("N2"));
                Console.WriteLine(a.ToString("C0"));
                Console.WriteLine(a.ToString("N2", new System.Globalization.CultureInfo("en-US")));

                string b = $"dette er et tal {a:N2} ....";
                Console.WriteLine(b);

            }

            {

                byte a = 200;
                int b = 350;
                Console.WriteLine(b);

                //a = Convert.ToByte(b);


                string c = "984984";
                double d = Convert.ToDouble(c);


                string tal1s = Console.ReadLine();
                string tal2s = Console.ReadLine();
                string talres = tal1s + tal2s;

                double t1 = Convert.ToDouble(tal1s);
                double t2 = Convert.ToDouble(tal2s);
                Console.WriteLine(t1+t2);




                }


        }
    }
}
