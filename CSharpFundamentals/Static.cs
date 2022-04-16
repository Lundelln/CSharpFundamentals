namespace CSharpFundamentals
{
    public class Static
    {


        public static int fetchDefault()
        {
            int maxAmount = 0;
            return maxAmount;
        }
    }

    public class StaticUser
    {
        int maxAmount = Static.fetchDefault();
    }
}
