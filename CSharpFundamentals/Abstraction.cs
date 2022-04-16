namespace CSharpFundamentals
{
    public class Abstraction
    {
        private int value = 1337;

        public class DerivedAbstraction : Abstraction
        {
            public int GetVaule()
            {
                return this.value;
            }
        }
    }
}
