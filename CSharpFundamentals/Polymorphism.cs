namespace CSharpFundamentals
{
    public class Polymorphism
    {
        public void Typing()
        {
            Console.WriteLine("Using keypad");
        }

        public void Typing(bool isSmartPhone)
        {
            Console.WriteLine("using qwerty keyboard");
        }

    }

    public class PolymorphismBase
    {
        public virtual void Speaking()
        {
            Console.WriteLine("Speaking out loud");
        }
    }


    public class PolymorphismOverride : PolymorphismBase
    {
        // method override
        public override void Speaking()
        {
            Console.WriteLine("Speaking function from child class");
        }
    }
}
