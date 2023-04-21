namespace learn_cs.src
{
    public class Destroyers
    {
        private string? myString = null;

        public Destroyers(string value)
        {
            myString = value;
        }

        ~Destroyers()
        {
            Console.WriteLine("Destructor called");
            myString = null;
        }

        public void PrintMyString()
        {
            Console.WriteLine("My string is: " + myString);
        }
    }
}
