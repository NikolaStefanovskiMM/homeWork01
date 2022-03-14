using System;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            string stringNum1 = Console.ReadLine();
            Console.WriteLine("Enter the first second");
            string stringNum2 = Console.ReadLine();
            Console.WriteLine("Enter the first 3th");
            string stringNum3 = Console.ReadLine();
            Console.WriteLine("Enter the first 4th");
            string stringNum4 = Console.ReadLine();

            int num1 = int.Parse(stringNum1);
            int num2 = int.Parse(stringNum2);
            int num3 = int.Parse(stringNum3);
            int num4 = int.Parse(stringNum4);

            double average = (num1 + num2 + num3 + num4) / 4;
            if(average > 0)
            {
                Console.WriteLine($"The average sum of this numbers: {num1}, {num2}, {num3}, {num4} is: {average}");
            }
            else
            {
                Console.WriteLine("Error! Cannot calculate average of 0");
            }
        }
    }
}
