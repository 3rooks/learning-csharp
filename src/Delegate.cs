namespace learn_cs.src
{
    public class Delegate
    {
        public delegate int Calculate(int x, int y);

        public class Calculator
        {
            public int Add(int x, int y)
            {
                return x + y;
            }

            public int Subtract(int x, int y)
            {
                return x - y;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Calculator calculator = new Calculator();
                Calculate operation = new Calculate(calculator.Add);
                int result = operation(5, 3);
                Console.WriteLine(result);

                operation = new Calculate(calculator.Subtract);
                result = operation(5, 3);
                Console.WriteLine(result);
            }
        }
    }
}