namespace CSharpFundamentals
{
    internal interface IInterface
    {
        public void Write(string text);
        public void Sharpen(string text);
    }

    internal class InterfaceClass : IInterface
    {
        public void Sharpen(string text)
        {
            throw new NotImplementedException();
        }

        public void Write(string text)
        {
            throw new NotImplementedException();
        }
    }

}
