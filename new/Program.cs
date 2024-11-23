using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my calculator : ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Please enter your first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter your second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Now please enter what operation would you like to do");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine("Your result is " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("Your result is " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("Your result is " + (num1 * num2));
                    break;
                case "/":
                    if (num2 != 0)
                        Console.WriteLine("Your result is " + (num1 / num2));
                    else
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please enter +, -, *, or /.");
                    break;
            }
        }
    }
}
