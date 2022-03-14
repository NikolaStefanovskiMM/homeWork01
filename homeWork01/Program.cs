using System;

namespace homeWork01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Homework - First exercise (Calculator)
            Console.WriteLine("Enter the first number");
            string stringNum1 = Console.ReadLine();
            Console.WriteLine("Enret the second number");
            string stringNum2 = Console.ReadLine();

            int num1 = int.Parse(stringNum1);
            int num2 = int.Parse(stringNum2);

            Console.WriteLine("Enter the operation");
            string calcOperator = Console.ReadLine();
            switch (calcOperator)
            {
                case "+":
                    Console.WriteLine("The result is: " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("The result is: " + (num1 - num2));
                    break;
                case "/":
                    Console.WriteLine("The result is: " + (num1 / num2));
                    break;
                case "*":
                    Console.WriteLine("The result is: " + (num1 * num2));
                    break;
                default:
                    Console.WriteLine($"Error! Invalid operator - {calcOperator}");
                    break;

            }
        }
    }
}
