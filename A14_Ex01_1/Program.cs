using System;

namespace Ex01
{
    public class Program
    {
        public static void Main()
        {
            int inputNumber;
            int firstInputNumber = 0;
            int ammountOfNumbersDividedByFirstNumber = 1;
            int sumOfInputNumbers = 0;
            int ammountOfNumbers = 0;
            int maxNum = 0;
            int minNum = 0;

            System.Console.WriteLine("Please enter integers. After each one press 'enter'. To Finish, enter '-1'.");
            string inputString = System.Console.ReadLine();
            int.TryParse(inputString, out inputNumber);
            while (inputNumber != -1)
            {
                if (!isPositiveInteger(inputString))
                {
                    System.Console.WriteLine("The input is not a positive integer, please enter a positive integer");
                }
                else
                {
                    if (ammountOfNumbers == 0)
                    {
                        firstInputNumber = inputNumber;
                        ammountOfNumbers++;
                        maxNum = inputNumber;
                        minNum = inputNumber;
                        sumOfInputNumbers += inputNumber;
                    }
                    else
                    {
                        sumOfInputNumbers += inputNumber;
                        ammountOfNumbers++;
                        if (firstInputNumber != 0)
                        {
                            if (inputNumber % firstInputNumber == 0)
                            {
                                ammountOfNumbersDividedByFirstNumber++;
                            }
                        }

                        if (inputNumber > maxNum)
                        {
                            maxNum = inputNumber;
                        }

                        if (inputNumber < minNum)
                        {
                            minNum = inputNumber;
                        }
                    }
                }

                inputString = System.Console.ReadLine();
                int.TryParse(inputString, out inputNumber);
            }

            if (ammountOfNumbers == 0)
            {
                System.Console.WriteLine("No positive integers were entered");
            }
            else
            {
                if (firstInputNumber == 0)
                {
                    ammountOfNumbersDividedByFirstNumber = 0;
                }

                System.Console.WriteLine(string.Format(@"
the max number is: {0}
the minimum number is: {1}
the average is: {2}
the ammount of numbers divided by first input number: {3}
", maxNum.ToString(), minNum.ToString(), (double)sumOfInputNumbers / ammountOfNumbers, ammountOfNumbersDividedByFirstNumber.ToString()));
            }

            System.Console.WriteLine("Press any key to exit the program...");
            System.Console.ReadLine();
        }

        public static bool isPositiveInteger(string i_String)
        {
            bool result = true;

            for (int i = 0; result != false && i < i_String.Length; i++)
            {
                if (!char.IsDigit(i_String[i]))
                {
                    result = false;
                }
            }

            return result;
        }
    }
}