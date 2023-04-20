namespace learn_cs.src
{
    public class Enums
    {
        enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        class Program
        {
            static void Main(string[] args)
            {
                DaysOfWeek today = DaysOfWeek.Monday;
                Console.WriteLine("Today is " + today);

                if (today == DaysOfWeek.Saturday || today == DaysOfWeek.Sunday)
                {
                    Console.WriteLine("It's the weekend!");
                }
                else
                {
                    Console.WriteLine("It's a weekday.");
                }
            }
        }


        enum Colors
        {
            Red,
            Green,
            Blue
        }

        static void Main(string[] args)
        {
            Colors color = Colors.Green;

            switch (color)
            {
                case Colors.Red:
                    Console.WriteLine("The color is red.");
                    break;
                case Colors.Green:
                    Console.WriteLine("The color is green.");
                    break;
                case Colors.Blue:
                    Console.WriteLine("The color is blue.");
                    break;
                default:
                    Console.WriteLine("The color is unknown.");
                    break;
            }
        }

        enum Gender
        {
            Male,
            Female
        }

        struct Person
        {
            public string Name;
            public int Age;
            public Gender Gender;
        }

        class Program1
        {
            static void Main(string[] args)
            {
                Person person1 = new Person
                {
                    Name = "John",
                    Age = 30,
                    Gender = Gender.Male
                };

                Person person2 = new Person
                {
                    Name = "Jane",
                    Age = 25,
                    Gender = Gender.Female
                };

                Console.WriteLine("{0} is {1} years old and {2}.", person1.Name, person1.Age, person1.Gender);
                Console.WriteLine("{0} is {1} years old and {2}.", person2.Name, person2.Age, person2.Gender);
            }
        }

    }
}