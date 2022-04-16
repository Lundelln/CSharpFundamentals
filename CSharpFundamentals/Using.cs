using System;

namespace CSharpFundamentals
{
    public class Using : IDisposable
    {
        private string _name { get; set; }
        private decimal _price { get; set; }

        public Using(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public void Print()
        {
            Console.WriteLine("Book name is {0} and price is {1}", _name, _price);
        }

        public void Dispose()
        {
            Console.WriteLine("Disposing");
        }
    }

    public class Students
    {
        public void PrintBook()
        {
            using (Using aBook = new Using("book", (decimal)12.45))
            {
                aBook.Print();
            }
        }
    }
}
