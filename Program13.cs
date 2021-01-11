using System;

namespace program13
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = "";
            Console.WriteLine("Podaj n");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                if ((n % 16) < 10) hex = n % 16 + hex;
                else
                {
                    string a = "";

                    switch (n % 16)
                    {
                        case 10:
                            a = "A";
                            break;
                        case 11:
                            a = "B";
                            break;
                        case 12:
                            a = "C";
                            break;
                        case 13:
                            a = "D";
                            break;
                        case 14:
                            a = "E";
                            break;
                        case 15:
                            a = "F";
                            break;
                    }
                    hex = a + hex;
                }
                n /= 16;
            }
            Console.WriteLine(hex);
        }

    }
}