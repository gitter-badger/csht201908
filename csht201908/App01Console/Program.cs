
using System;

namespace App01Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //Console.WriteLine("lksjdf");
            //Cronberg.Terning t = new Cronberg.Terning();

            Console.WriteLine();
            Console.WriteLine("test");
            int res = Math.Max(5, 5);

            Console.WriteLine("Skriver en tekst...");
            string a = "Skriver en anden tekst";
            Console.WriteLine(a);

            Console.Write("a");
            Console.Write("b");
            Console.Write("c");
            Console.WriteLine();

            Console.WriteLine("Indtast tal");
            string tal = Console.ReadLine();
            Console.WriteLine(tal);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Blå");
            Console.ForegroundColor = ConsoleColor.Gray;
            
        }
    }
}


