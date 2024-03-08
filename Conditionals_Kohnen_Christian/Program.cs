namespace Conditionals_Kohnen_Christian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asksk user to input a number
            Console.WriteLine("Please type a positive or negative number!");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You typed the number {numberOne}");

            //checks if it is positive or negative
            if (numberOne >= 0) {
                Console.WriteLine($"{numberOne} is a positive number!");
            } else {
                Console.WriteLine($" {numberOne} is a negative number!");
            }

            //checks if it is even or odd
            if (numberOne % 2 == 0) {
                Console.WriteLine($"{numberOne} is an even number as well!");
            } else {
                Console.WriteLine($"{numberOne} is an odd number as well!");
            }

            //creates two more numbers
            int num1 = 33;
            int num2 = 52;

            //compares the two nums with numberOne and sees which is higher
            int firstMax = Math.Max(numberOne, num1);
            int max = Math.Max(firstMax, num2);
            Console.WriteLine($"The biggest number of {num1}, {num2}, and {numberOne} is {max}!");

            //asks user for a grade
            Console.WriteLine("Please put in YOUR grade (A, B, C, D, F)");
            char grade = Console.ReadKey().KeyChar;

            //prints praise or pressure based on grade value
            switch (grade){
                case 'A':
                    Console.WriteLine("\nSuperior!");
                    break;
                case 'B':
                    Console.WriteLine("\nVery Good!");
                    break;
                case 'C':
                    Console.WriteLine("\nAverage!");
                    break;
                case 'D':
                    Console.WriteLine("\nBelow Average!");
                    break;
                case 'F':
                    Console.WriteLine("\nFail!");
                    break;
                default:
                    Console.WriteLine("\nYou did not enter a valid grade. Did you forget to captialize it?");
                    break;
            }
        }
    }
}