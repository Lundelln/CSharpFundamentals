namespace CSharpFundamentals
{
    public class Constants
    {
        public const int myVar = 101;
        public const string myVar2 = "consString";


        public readonly int myVar3;
        public readonly string myVar4;
        public Constants(int myVar3, string myVar4)
        {
            this.myVar3 = myVar3;
            this.myVar4 = myVar4;

        }

        public void Main()
        {
            Console.WriteLine("The vaule of myVar: {0}", myVar);
            Console.WriteLine("The vaule of myVar2: {0}", myVar2);

            Constants constant = new Constants(111, "readOnlyString");
            Console.WriteLine("The vaule of myVar3: {0}", myVar3);
            Console.WriteLine("The vaule of myVar4: {0}", myVar4);

        }
    }
}
