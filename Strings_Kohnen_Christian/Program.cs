namespace Strings_Kohnen_Christian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a character from your keyboard!"); //asksk to input a letter
            char theirChar = Console.ReadKey().KeyChar; //gives value to the variable "theirCharacter"
           
            bool isLetter = char.IsLetter(theirChar); //checks to see is letter is indeed a letter
            Console.WriteLine($"\n {theirChar} is a {isLetter} letter!"); //displays their character and says if it is or in not a letter


            Console.WriteLine("Please write a string of words. Press enter when done."); //asks to write a sentence
            string sentence = Console.ReadLine(); //gives the sentence a value

            Console.WriteLine("enter a word"); //asks to type in a word
            string word = Console.ReadLine(); // gives the word a value
            bool isIn = sentence.Contains(word); //sees if the value of the word is in the sentence

            Console.WriteLine($"the word \"{word}\" in in  the phrase \"{sentence}\", this is {isIn}."); //tells if the word is in the sentence
        }
    }
}