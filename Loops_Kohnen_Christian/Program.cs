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

            Console.WriteLine("Please input a number!"); //asks user to place a number
            string number = Console.ReadLine(); //saves responce as number
            Console.WriteLine($"the sum of those two digits are {SumOfDigit(number)}"); //writes sum of the loop
        }

        static int CountNumberOfSpaces(string sentence) //makes the parameters for "CountNumberOfSpaces"
        {
            int numberOfSpaces = 0; //sets number of spaces as zero before loop
            foreach (char character in sentence) //sets up loop for to check the sentence 
            {
                if (character == ' ') //looks for sapaces in the sentence and adds to the variable "numberOfSpaces" by one
                {
                    numberOfSpaces++;
                }
            }
            return numberOfSpaces; //breaks loop
        }

        static int SumOfDigit(string number) //makes the parameters for "SumOfDigit"
        {
            int sum = 0; //sets the number as zero before loop
            foreach (char digit in number) //sets up loop to check digits
            {
                sum += (int)Char.GetNumericValue(digit); //adds the value of the digits to the sum
            }
            return sum; //breaks loop
        }
    }
}