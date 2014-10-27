using System;

namespace Ex04
{
    public class Program
    {
        public static void Main()
        {
            bool isNumBinary;
            int decimalValueOfBinaryString;

            System.Console.WriteLine("Please enter a 5 bit binary string");
            string inputString = System.Console.ReadLine();
            isNumBinary = isStringBinaryNum(inputString);
            if (inputString.Length == 5 && isNumBinary)
            {
                decimalValueOfBinaryString = convertBinaryStringToDecimal(inputString);
                System.Console.WriteLine("The decimal value of the binary number is: " + decimalValueOfBinaryString);
                if (isPrime(decimalValueOfBinaryString))
                {
                    System.Console.WriteLine("the decimal number is prime");
                }
                else
                {
                    System.Console.WriteLine("The decimal number is not prime");
                }
            }
            else
            {
                System.Console.WriteLine("The input string is not a 5 bit binary string\n");
            }

            System.Console.WriteLine("Press any key to exit...");
            System.Console.ReadLine();
        }

        public static bool isStringBinaryNum(string i_String)
        {
            bool result = true;

            for (int i = 0; result != false && i < i_String.Length; i++)
            {
                if (i_String[i] != '0' && i_String[i] != '1')
                {
                    result = false;
                }
            }

            return result;
        }

        public static int convertBinaryStringToDecimal(string i_string)
        {
            int decimalValue = 0;
            int binaryDigit;

            for (int i = 0; i < i_string.Length; i++)
            {
                int.TryParse(i_string[i].ToString(), out binaryDigit);
                decimalValue += (int)Math.Pow(2, (double)(i_string.Length - 1 - i)) * binaryDigit;
            }

            return decimalValue;
        }

        public static bool isPrime(int i_Num)
        {
            bool result = true;

            if (i_Num < 2)
            {
                result = false;
            }

            for (int i = 2; result != false && i <= (int)Math.Sqrt((double)i_Num); i++)
            {
                if (i_Num % i == 0)
                {
                    result = false;
                }
            }

            return result;
        }
    }
}