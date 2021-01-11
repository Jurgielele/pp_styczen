
using System;
using static System.Math;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a;
            Console.WriteLine("Podaj 1<=n<=1000");
            n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj elementy");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(tab);
            Console.WriteLine("Min: " + tab[0]);
            Console.WriteLine("Max: " + tab[n-1]);


        }
    }
}