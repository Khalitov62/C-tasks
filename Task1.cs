using System;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            double firstNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            Console.WriteLine("Enter operator");
            char op = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n-----\n");
            Console.WriteLine("Result");
        }
        public static void Math(double number1, double number2, char opp)
        {
            double total = 0;
            if (opp == '+')
            {
                total = number1 + number2;
                Console.WriteLine(total);
            }
            else if (opp == '-')
            {
                total = number1 - number2;
                Console.WriteLine(total);
            }
            else if (opp == '*')
            {
                total = number1 * number2;
                Console.WriteLine(total);
            }
            else if (opp == '/')
            {
                total = number1 / number2;
                Console.WriteLine("total");
                {
                }
            }
        }
    }
}
