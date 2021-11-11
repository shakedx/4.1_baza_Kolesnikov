using System;

namespace _4._1_baza_Kolesnikov
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] M = new double[15];
            Random rnd = new Random();
            for (int i = M.Length-1; i >=0 ;i--)
            {
                M[i] = Math.Round(rnd.NextDouble() * 100, 2);
                Console.WriteLine(M[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
