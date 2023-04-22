namespace learn_cs.src
{
    public class Predicate
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                Predicate<int> isEven = (int x) => x % 2 == 0;
                Predicate<int> isGreaterThanFive = (int x) => x > 5;

                List<int> evenNumbers = numbers.FindAll(isEven);
                List<int> numbersGreaterThanFive = numbers.FindAll(isGreaterThanFive);

                Console.WriteLine("Even numbers:");
                foreach (int num in evenNumbers)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();

                Console.WriteLine("Numbers greater than five:");
                foreach (int num in numbersGreaterThanFive)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}