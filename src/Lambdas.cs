namespace learn_cs.src
{
    public class Lambdas
    {
        public static void Main()
        {
            var names = new List<string>() { "Alice", "Bob", "Charlie", "Dave", "Eve" };
            names.Sort((name1, name2) => name1.Length.CompareTo(name2.Length));
            Console.WriteLine(string.Join(", ", names));

            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where(number => number % 2 == 0);
            Console.WriteLine(string.Join(", ", evenNumbers));

            var people = new List<Person>() {
                new Person() { Name = "Alice", Age = 25 },
                new Person() { Name = "Bob", Age = 30 },
                new Person() { Name = "Charlie", Age = 20 }
            };
            var namesOfPeopleOver25 = people.Where(person => person.Age > 25).Select(person => person.Name);
            Console.WriteLine(string.Join(", ", namesOfPeopleOver25));

            var numbers2 = new List<int>() { 1, 2, 3, 4, 5 };
            var sum = numbers2.Aggregate((acc, number) => acc + number);
            Console.WriteLine(sum);

            Func<int, Func<int, int>> add = x => y => x + y;
            var add2 = add(2);
            Console.WriteLine(add2(3));
        }

        public class Person
        {
            public string Name { get; set; } = "";
            public int Age { get; set; }
        }
    }
}