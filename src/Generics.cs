namespace learn_cs.src
{
    public class Generics
    {
        public class Stack<T>
        {
            private int top;
            private T[] items;

            public Stack(int size)
            {
                items = new T[size];
                top = -1;
            }

            public void Push(T item)
            {
                if (top == items.Length - 1)
                {
                    throw new StackOverflowException("Stack is full");
                }

                items[++top] = item;
            }

            public T Pop()
            {
                if (top == -1)
                {
                    throw new InvalidOperationException("Stack is empty");
                }

                return items[top--];
            }

            public T Peek()
            {
                if (top == -1)
                {
                    throw new InvalidOperationException("Stack is empty");
                }

                return items[top];
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                var intStack = new Stack<int>(10);

                intStack.Push(1);
                intStack.Push(2);
                intStack.Push(3);

                Console.WriteLine(intStack.Pop());
                Console.WriteLine(intStack.Pop());
                Console.WriteLine(intStack.Pop());

                var stringStack = new Stack<string>(10);

                stringStack.Push("hello");
                stringStack.Push("world");
                stringStack.Push("!");

                Console.WriteLine(stringStack.Pop());
                Console.WriteLine(stringStack.Pop());
                Console.WriteLine(stringStack.Pop());
            }
        }
    }
}