using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        int diamondHeight;

        System.Console.WriteLine("Please enter diamond's height:");
        string inputString = Console.ReadLine();
        while (!Ex01.Program.isPositiveInteger(inputString))
        {
            System.Console.WriteLine("Please enter positve integer:");
            inputString = Console.ReadLine();
        }

        diamondHeight = int.Parse(inputString);
        Ex02.Program.printDiamond(diamondHeight);
        System.Console.WriteLine("Press any key to exit...");
        System.Console.ReadLine();
    }
}