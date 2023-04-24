using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthTask
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter Logic expression: ");
            string expression = Console.ReadLine();

            try
            {
                bool result = ParseExpression(expression);
                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error Format");
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine($"Error: {exception.Message}");
            }
        }

        static bool ParseExpression(string input)
        {
            string[] StringValues = input.Split(' ');

            if (StringValues.Length != 3)
            {
                throw new FormatException();
            }

            int left = int.Parse(StringValues[0]);
            int right = int.Parse(StringValues[2]);

            switch (StringValues[1])
            {
                case "<": return left < right;
                case ">": return left > right;
                case "<=": return left <= right;
                case ">=": return left >= right;
                case "==": return left == right;
                case "!=": return left != right;
                default: throw new ArgumentException("Error Operator");
            }
        }
    }
}
