namespace Methods_Kohnen_Christian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number"); //asks user to insert another whole number
            int x = Convert.ToInt32(Console.ReadLine()); //saves user input as variable X
            Console.WriteLine("Enter another whole number"); //asks user to insert another whole number
            int y = Convert.ToInt32(Console.ReadLine()); //saves user input as variable Y

            Console.WriteLine(Multiplicatable(x, y)); //writes out the multiplication method in the main method


            Console.WriteLine("Please enter your name"); //Asks user for their name
            string name = Console.ReadLine(); //saves the name into the {name} variable
            Welcome(name);

            Bye(name);
        }

        static int Multiplicatable(int n1, int n2) //creates multiplicatable method and names varables n1 and n2
        {
            return n1 * n2; //multiplies the first and second variable inserted from the user
        }

        static void Welcome(string name)
        {
            Console.WriteLine($"Hello, {name}! it is nice to know your name"); //creates the welcome method messege and saves the {name} variable
        }

        static void Bye(string name)
        {
            Console.WriteLine($"Goodbye, {name}!"); //creating the goodbye method message and using the {name} from the other method
        }

    }
}