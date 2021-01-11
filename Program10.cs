using System;

namespace program10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
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
                sum += element * element;
            }
            Console.WriteLine("Sum: " + sum);


        }
    }
}
