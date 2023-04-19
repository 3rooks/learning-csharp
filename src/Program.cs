using learn_cs.src;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Constructor Example = new Constructor("username", 66);

            Example.Age = 99;
            Example.Name = "USERNAME";

            Console.WriteLine($"Username: {Example.Name}, Age: {Example.Age}");
        }
    }
}
