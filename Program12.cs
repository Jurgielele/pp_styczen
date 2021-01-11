using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string oct = "";
            Console.WriteLine("Podaj n");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n>0)
            {
                oct = n % 8 + oct;
                n /= 8;
            }
            Console.WriteLine(oct);
        }

    }
}
