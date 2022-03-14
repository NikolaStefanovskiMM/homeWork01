using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swaping");
            static void SwapNum(ref int x, ref int y)
            {

                int tempswap = x;
                x = y;
                y = tempswap;
            }
            Console.WriteLine("Enter the first value:");
            string stringA = Console.ReadLine();
            Console.WriteLine("Enter the second value:");
            string stringB = Console.ReadLine();

            int a = int.Parse(stringA);
            int b = int.Parse(stringB);
            Console.WriteLine("Value of a and b before sawapping");
            Console.WriteLine();
            Console.WriteLine("a=" + " " + a);
            Console.WriteLine("b=" + " " + b);
            SwapNum(ref a, ref b);
            Console.WriteLine();
            Console.WriteLine("Value of a and b after sawapping");
            Console.WriteLine();
            Console.WriteLine("a=" + " " + a);
            Console.WriteLine("b=" + " " + b);
            Console.ReadLine();
        }
    }
}
