using System.Reflection.Metadata.Ecma335;

namespace Loops_Kohnen_Christian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to make games?"); //asks the user a question
            string sentence = Console.ReadLine(); //saves responce as "sentence"
            Console.WriteLine($" that sentence has {CountNumberOfSpaces(sentence)} spaces in it!"); //prints the result of CountNumberOfSpaces

            Console.WriteLine("Please input a number!");
            string number = Console.ReadLine();
            Console.WriteLine($"the sum of those two digits are {SumOfDigit(number)}");
        }

        static int CountNumberOfSpaces(string sentence) //
        {
            int numberOfSpaces = 0; //sets number of spaces as zero before loop
            foreach (char character in sentence) //
            {
                if (character == ' ') //looks for sapaces in the sentence and adds to the variable "numberOfSpaces" by one
                {
                    numberOfSpaces++;
                }
            }
            return numberOfSpaces; //breaks loop
        }

        static int SumOfDigit(string number)
        {
            int sum = 0;
            foreach (char digit in number)
            {
                sum += (int)Char.GetNumericValue(digit);
            }
            return sum;
        }
    }
}