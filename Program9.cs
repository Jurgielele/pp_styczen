using System;

namespace program9

{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Podaj 1<=n<=1000");
            n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj elementy");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(tab);
            foreach (int element in tab)
            {
                if (element % 2 == 0) Console.WriteLine(element);
            }


        }
    }
}