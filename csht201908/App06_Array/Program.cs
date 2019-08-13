using System;

namespace App06_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] a1 = new int[3];  // initialiseret til default værdier [0,0,0]
            a1[0] = 40;
            a1[1] = 8;
            a1[2] = 100;

            string s = String.Join(',', a1);
            Console.WriteLine(s);

            //Console.WriteLine(a1.Length);

            //for (int i = 0; i < a1.Length; i++)
            //{
            //    Console.WriteLine(a1[i]);
            //}

            //foreach (int item in a1)
            //{
            //    Console.WriteLine(item);
            //}

            System.Array.Resize(ref a1, 4);
            a1[3] = 5;

            //System.Array.Sort(a1);

            
            int r = FindMindsteTal(a1);

            string g = "4;32";
            //string[] h = g.Split(';');
            var h = g.Split(';');

        }

        static int FindMindsteTal(int[] a) {
            int[] kopi = a.Clone() as int[];
            System.Array.Sort(kopi);
            return kopi[0];
        }

    }
}
