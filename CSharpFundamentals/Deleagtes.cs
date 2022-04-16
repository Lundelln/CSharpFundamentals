namespace CSharpFundamentals
{
    public class Deleagtes
    {
        public delegate void Print(int value);

        // the delegate can ge casted to either this method
        public static void PrintNumber(int num)
        {
            Console.WriteLine($"Number {num,-12:N0}");
        }

        // or this method or multicasted to both
        public static void PrintMoney(int num)
        {
            Console.WriteLine($"Money {num:c}");
        }
    }
}
