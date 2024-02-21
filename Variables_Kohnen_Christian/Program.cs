namespace Variables_Kohnen_Christian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int favNumber; //declares int varable 
            bool isJumping = false, isRunning = false; //sets bool variable isJumping and isRunning as faslse
            float Nyumer; //declares float as Nyumer
            favNumber = 55; //gives favNumber a number
            Nyumer = 0.25f; //gives Myumer a number
            const double finalGrade = 85.5; //declares and gives finalGrade an number

            Console.WriteLine("My favorite number"favNumber); //all of then write a small message next to the variables
            Console.WriteLine("Jumping?"isJumping);
            Console.WriteLine("Running"isRunning);
            Console.WriteLine("just a number"Nyumer);
            Console.WriteLine("My final grade"finalGrade);
        }
    }
}