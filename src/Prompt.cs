namespace learn_cs.src
{
    public class Prompt
    {
        public void userPrompt()
        {
            Console.WriteLine("Hello, world!");

            Console.WriteLine("Username:");
            string? userName = Console.ReadLine();

            Console.WriteLine("Age:");
            string? ageString = Console.ReadLine();

            if (int.TryParse(ageString, out int userAge))
            {
                Console.WriteLine($"Hello, {userName}! You are {userAge} years old.");
            }
            else
            {
                Console.WriteLine("Invalid age value.");
            }
        }
    }
}