namespace Arrays_Kohnen_Christian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a size for the Array in numbers!");  //asks the User to place a size for the Array
            int arraySize = Convert.ToInt32(Console.ReadLine());  //keeps the inptued numbers and assigns them to "arraySize"
            int[] numbers = new int[arraySize];  //assigns the Array "numbers" from the variable "array size"
            int sum = 0;  //sets the sum default to zero

            for(int i=0; i<numbers.Length; i++) //loops to assign a value to each Array number
            {
                Console.WriteLine("Please enter a whole number FOR the Array!");  //asks the user to input a number for the Array
                numbers[i] = Convert.ToInt32(Console.ReadLine());  //keeps the inputed numbers to the intiger
                sum += numbers[i];  //makes the sum the added sum of the given numbers
            }
            Console.WriteLine($"The sum of the array is {sum}\n");  //tells the user the sum of the Array
            Array.Sort(numbers);  //sorts the numbers

            Console.WriteLine("The Array");  //Titles the Array
            foreach(int number in numbers)  //loops to write the numbers individualy
            {
                Console.WriteLine(number);  //Writes the sorted number
            }
        }
    }
}