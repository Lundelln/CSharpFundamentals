
namespace CSharpFundamentals
{
    public class Program
    {
        private static int mainValue;

        static void Main(string[] args)
        {
            Console.WriteLine(mainValue = Constants.myVar);
            Console.WriteLine(mainValue = Constants.myVar);
            Constants constants = new Constants(111, "testString");
            Console.WriteLine(constants.myVar4, constants.myVar3);

            constants.Main();
        }
    }
}