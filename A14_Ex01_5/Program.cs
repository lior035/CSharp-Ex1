using System;

public class Program
{
    public static void Main()
    {
        int numberOfLowerEnglishLetterInInput = 0;
        int numberOfUpperEnglishLetterInInput = 0;
        int numberOfDigitsInInput = 0;
        int numberOfSpacesInInput = 0;

        System.Console.WriteLine("Please enter a sentence and than press Enter");
        string inputLineFromUser = System.Console.ReadLine();

        // Assumption: characters in the input line from user is legal (validity check was not requested)
        foreach (char currentCharInUserStringInput in inputLineFromUser)
        {
            if (char.IsDigit(currentCharInUserStringInput))
            {
                numberOfDigitsInInput++;
            }
            else if (char.IsLower(currentCharInUserStringInput))
            {
                numberOfLowerEnglishLetterInInput++;
            }
            else if (char.IsUpper(currentCharInUserStringInput))
            {
                numberOfUpperEnglishLetterInInput++;
            }
            else if (char.IsWhiteSpace(currentCharInUserStringInput))
            {
                numberOfSpacesInInput++;
            }
        }

        string outputMsg = string.Format(
@"Here is the lexicographic analysis for the input sentence you provided :
Number of lower english letter is {0}.
Number of upper english letter is {1}.
Number of digits is {2}.
number of spaces is {3}.
Thank you.",
                numberOfLowerEnglishLetterInInput, numberOfUpperEnglishLetterInInput, numberOfDigitsInInput, numberOfSpacesInInput);

        // the program's output:
        Console.WriteLine(outputMsg);
        Console.WriteLine("Press any key to exit....");
        Console.ReadLine();
    }
}