namespace CSharpFundamentals
{
    public class Encapsulation
    {
        string address;
        private string name;
        
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
