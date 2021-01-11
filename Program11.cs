using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int a = 0; int b = 0; int c = 0;
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
                if(element == 0)
                {
                    a++;
                }else if(element > 0)
                {
                    b++;
                } else
                {
                    c++;
                }
            }
            Console.WriteLine("i == 0: " + a);
            Console.WriteLine("i > 0: " + b);
            Console.WriteLine("i < 0: " + c);


        }
    }
}
