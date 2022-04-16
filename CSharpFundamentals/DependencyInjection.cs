using Microsoft.Extensions.Logging;

namespace CSharpFundamentals
{
    public class DependencyInjection
    {
        // constructor dependency injection
        public DependencyInjection(string name, Logger logger)
        {
            logger.Log($"{name} is logged");
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // property dependency injection 
        public ILogger Logger { get; set; }

        public Person(string name, int age, ILogger logger)
        {
            Name = name;
            Age = age; 
            Logger = logger;
        }

        // method dependecy injection
        public void Display(ILogger logger)
        {
            logger.Log($"The person's name is {Name}");
        }
    }

    public class Logger
    {
        public void Log(string value)
            {
                Console.WriteLine($"{value} is logged");
            }
    }

    public interface ILogger
    {
        void Log(string value);
    }
}
