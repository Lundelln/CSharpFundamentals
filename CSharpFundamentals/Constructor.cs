namespace CSharpFundamentals
{
    public class Constructor
    {
        private string fName { get; set; }
        private string lName { get; set; }

        // default constructor
        public Constructor()
        {

        }

        // parameterized constructor
        public Constructor(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
        }

        // static constructor
        static Constructor()
        {

        }

        // copy constructor
        public Constructor(Constructor constructor)
        {
            this.fName = constructor.fName;
            this.lName = constructor.lName;
        }

    }
}
