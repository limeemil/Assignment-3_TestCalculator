using System;
using System.Globalization;

namespace Assignment_3__TestCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            string userInput;
            double term1, term2, factor1, factor2, num, den, sum, diff, product, ratio;
            Console.WriteLine("Calculator");
            do
            {
                Console.WriteLine("Options:");
                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Subtraction");
                Console.WriteLine("3: Multiplication");
                Console.WriteLine("4: Division");
                Console.WriteLine("0: Exit");
                Console.Write("What do you want to do? Enter the corresponding number: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        term1 = GetNumberFromUser();
                        term2 = GetNumberFromUser();
                        sum = MyMath.Addition(term1, term2);
                        Console.WriteLine("The sum is: " + sum);
                        break;

                    case "2":
                        term1 = GetNumberFromUser();
                        term2 = GetNumberFromUser();
                        diff = MyMath.Subtraction(term1, term2);
                        Console.WriteLine("The difference is: " + diff);
                        break;

                    case "3":
                        factor1 = GetNumberFromUser();
                        factor2 = GetNumberFromUser();
                        product = MyMath.Subtraction(factor1, factor2);
                        Console.WriteLine("The product is: " + product);
                        break;

                    case "4":
                        num = GetNumberFromUser();
                        den = GetNumberFromUser();
                        try
                        {
                            ratio = MyMath.Division(num, den);
                            Console.WriteLine("The ratio is: " + ratio);
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Denominator cannot be 0, please try again");
                        }
                        break;

                    case "0":
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input, please try again.");
                        break;
                }
            }
            while (isRunning);
        }
        static double GetNumberFromUser()
        {
            double number = 0;
            bool success = false;
            string input;

            while (!success)
            {
                Console.Write("Enter a number: ");
                input = Console.ReadLine();
                success = double.TryParse(input.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out number);
                if (!success)
                {
                    Console.WriteLine("Invalid input, please write a number.");
                }
            }
            return number;
        }
    }
    
}
