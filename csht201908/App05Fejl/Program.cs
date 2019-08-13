using System;

namespace App05Fejl
{
    class Program
    {
        static void Main(string[] args)
        {

            //string a = null;
            //a.ToUpper();

            //try
            //{
            //    //string b = System.IO.File.ReadAllText(@"c:\temp\data.txt");
            //    string a = Console.ReadLine();
            //    double b = Convert.ToDouble(a);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Fejl " + ex.Message);
            //}
            //finally {
            //    Console.WriteLine("kører altid...");
            //}


            //try
            //{
            //    Run();
            //}
            //catch (Exception ex)
            //{
            //    //if(ex.InnerException!=null)
            //    //    Console.WriteLine(ex.InnerException.Message);

            //    Console.WriteLine("Fejl " + ex.Message);
            //}

            //try
            //{
            //    int tal = HentTalFraFil(@"c:\temp\data.txt");
            //}
            //catch (Exception ex)
            //{
            //    if (ex.InnerException != null)
            //        Console.WriteLine(ex.InnerException.Message);

            //    Console.WriteLine("Fejl " + ex.Message);

            //}
            try
            {
                Console.WriteLine(LægSammen(15, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fejl " + ex.Message);
            }

        }

        static int LægSammen(int a, int b) {
        
            try
            {
                if (a > 10 || b > 10)
                {
                    //ApplicationException ex = new ApplicationException("For stort tal");
                    throw new ArgumentException("For stort tal");
                }
                return a + b;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally {
                Console.WriteLine("*");
            }
        }

        private static int HentTalFraFil(string sti)
        {
            try
            {
                string talSomStreng = System.IO.File.ReadAllText(sti);
                int tal = Convert.ToInt32(talSomStreng);
                return tal;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Kan ikke konvertere tal fra {sti}", ex);
            }
        }

        static void Run()
        {
            Test1();
        }

        static void Test1()
        {
            Test2();
        }
        static void Test2()
        {
            Test3();
        }
        static void Test3()
        {

            string a = null;
            a.ToLower();

        }

    }
}
