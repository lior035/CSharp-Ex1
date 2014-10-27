using System;
using System.Text;

namespace Ex02
{
    public class Program
    {
        public static void Main()
        {
            const int DiamondSize = 5;

            printDiamond(DiamondSize);
            System.Console.WriteLine("Press any key to exit...");
            System.Console.ReadLine();
        }

        public static void printDiamond(int i_Height)
        {
            StringBuilder diamondString = new StringBuilder();

            for (int i = 0; i <= (i_Height / 2); i++)
            {
                diamondString.Append(' ', (i_Height / 2) - i).Append('*', (i * 2) + 1).AppendLine();
            }

            for (int i = (i_Height / 2) - 1; i >= 0; i--)
            {
                diamondString.Append(' ', (i_Height / 2) - i).Append('*', (i * 2) + 1).AppendLine();
            }

            System.Console.WriteLine("Here is your diamond : \n\n" + diamondString.ToString());
        }
    }
}
