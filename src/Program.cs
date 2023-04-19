using learn_cs.src;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John Doe", 30);

            if (person.IsNameValid())
            {
                Console.WriteLine("Name is valid");
            }

            if (person.IsAgeValid())
            {
                Console.WriteLine("Age is valid");
            }
        }
    }
}
