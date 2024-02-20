using System; //needed to use consose class//

namespace HelloWorld_KohnenChristian //collection of classes for the project//
{
    internal class Program
    {
        static void Main(string[] args) //executed Main method to start //
        {
           
            Console.WriteLine("What is yoru first name?"); // Asks for first name //
            string firstName = Console.ReadLine(); // Assigns first name //
            Console.WriteLine("What is yoru last name?"); // Asks for last name //
            string lastName = Console.ReadLine(); // Assigns for last name //

            Console.WriteLine($"Hello, {firstName} {lastName}!"); // Prints message with first and last name variables //
        }
    }
}