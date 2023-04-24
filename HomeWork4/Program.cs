using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an Option:");
            Console.WriteLine("1. Decimal to Binary");
            Console.WriteLine("2. Binary to Decimal");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Decimal Number: ");
                    int decimalNumber = int.Parse(Console.ReadLine());
                    string binaryNumber = DecimalToBinary(decimalNumber);
                    Console.WriteLine($"Number: {decimalNumber} In Binary Representation: {binaryNumber}");
                    break;
                case 2:
                    Console.WriteLine("Enter Binary Number:");
                    string binaryNumbers = Console.ReadLine();
                    int decimalNumbers = BinaryToDecimal(binaryNumbers);
                    Console.WriteLine($"Number: {binaryNumbers} In Decimal Representation:  {decimalNumbers}");
                    break;
            }
        }

        static string DecimalToBinary(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 2);
        }

        
        static int BinaryToDecimal(string binaryNumber)
        {
            try
            {
                return Convert.ToInt32(binaryNumber, 2);
            }
            catch (Exception)
            {
                Console.WriteLine("Error Number is Not in Binary Representation");
                return 0;
            }
        }
    }
}
