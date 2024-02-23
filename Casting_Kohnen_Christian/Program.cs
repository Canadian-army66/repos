namespace Casting_Kohnen_Christian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monkey? True or False?"); //asks user a true or false question
            bool isTrue = Convert.ToBoolean(Console.ReadLine()); //user responds true or false
            Console.WriteLine($"of course, Monkey is {isTrue}!"); //prints response with user input

            Console.WriteLine("How many Monkey?"); //asks user for a whole number
            int favNyum = Convert.ToInt32(Console.ReadLine()); //user places a number specifically
            Console.WriteLine($"There are going to be {favNyum} Monkey in your walls!"); //prints out responce with user input
        }
    }
}