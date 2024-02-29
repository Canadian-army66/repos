namespace Operators_Kohnen_Christian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intMultiply = 3 * 49; //declares multiplied intigers
            int intAddition = 3 + 50; //declares added intigers
            Console.WriteLine($"The max of {intMultiply} and of {intAddition} is {Math.Max(intMultiply, intAddition)} " +
                $"and the minimum of the two is {Math.Min(intMultiply, intAddition)}"); //it finds the min and max of the two numbers
            bool isIntGreater = intMultiply > intAddition; //ir finds which is greater and if the statement is true
            Console.WriteLine($"{ intMultiply} is greater than {intAddition}, {isIntGreater}"); //types that one value os greater than the other and that iot it indeed true

            short shortMultiply = 3 * 49; //declares multiplied intigers
            short shortAddition = 3 + 50; //declares added intigers
            Console.WriteLine($"The max of {shortMultiply} and of {shortAddition} is {Math.Max(shortMultiply, shortAddition)} " +
                $"and the minimum of the two is {Math.Min(shortMultiply, shortAddition)}"); //it finds the min and max of the two numbers
            bool isShortGreater = shortMultiply > shortAddition; //ir finds which is greater and if the statement is true
            Console.WriteLine($"{shortMultiply} is greater than {shortAddition}, {isShortGreater}"); //types that one value os greater than the other and that iot it indeed true

            long longMultiply = 3 * 49; //declares multiplied intigers
            long longAddition = 3 + 50; //declares added intigers
            Console.WriteLine($"The max of {longMultiply} and of {longAddition} is {Math.Max(longMultiply, longAddition)} " +
                $"and the minimum of the two is {Math.Min(longMultiply, longAddition)}"); //it finds the min and max of the two numbers
            bool isLongGreater = longMultiply > longAddition; //ir finds which is greater and if the statement is true
            Console.WriteLine($"{longMultiply} is greater than {longAddition}, {isLongGreater}"); //types that one value os greater than the other and that iot it indeed true

            double doubleMultiply = 3 * 49; //declares multiplied intigers
            double doubleAddition = 3 + 50; //declares added intigers
            Console.WriteLine($"The max of {doubleMultiply} and of {doubleAddition} is {Math.Max(doubleMultiply, doubleAddition)} " +
                $"and the minimum of the two is {Math.Min(doubleMultiply, doubleAddition)}"); //it finds the min and max of the two numbers
            bool isDoubleGreater = doubleMultiply > doubleAddition; //ir finds which is greater and if the statement is true
            Console.WriteLine($"{doubleMultiply} is greater than {doubleAddition}, {isDoubleGreater}"); //types that one value os greater than the other and that iot it indeed true

            decimal decimalMultiply = 3 * 49; //declares multiplied intigers
            decimal decimalAddition = 3 + 50; //declares added intigers
            Console.WriteLine($"The max of {decimalMultiply} and of {decimalAddition} is {Math.Max(decimalMultiply, decimalAddition)} " +
                $"and the minimum of the two is {Math.Min(decimalMultiply, decimalAddition)}"); //it finds the min and max of the two numbers
            bool isDecGreater = decimalMultiply > decimalAddition; //ir finds which is greater and if the statement is true
            Console.WriteLine($"{decimalMultiply} is greater than {decimalAddition}, {isDecGreater}"); //types that one value os greater than the other and that iot it indeed true
        }
    }
}