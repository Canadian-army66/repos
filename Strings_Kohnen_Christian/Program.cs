namespace Strings_Kohnen_Christian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a character from your keyboard!");
            char theirChar = Console.ReadKey().KeyChar;
           
            bool isLetter = char.IsLetter(theirChar);
            Console.WriteLine($"\n {theirChar} is a {isLetter} letter!");


            Console.WriteLine("Please write a string of words");
            string sentence = Console.ReadLine();

            Console.WriteLine("enter a word");
            string word = Console.ReadLine();
            bool isIn = sentence.Contains(word);

            Console.WriteLine($"the word {word} in in  the phrase \"{sentence}\", this is {isIn}");
        }
    }
}