using System.Collections.Generic;

namespace learn_cs.src
{
    public class Collections
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<int> numbersList = new List<int>();
                numbersList.Add(10);
                numbersList.Add(20);
                numbersList.Add(30);

                Console.WriteLine("List Example:");
                foreach (int number in numbersList)
                {
                    Console.WriteLine(number);
                }

                Dictionary<string, int> ageDictionary = new Dictionary<string, int>();
                ageDictionary.Add("Alice", 25);
                ageDictionary.Add("Bob", 30);
                ageDictionary.Add("Charlie", 35);

                Console.WriteLine("Dictionary Example:");
                foreach (KeyValuePair<string, int> item in ageDictionary)
                {
                    Console.WriteLine("{0}: {1}", item.Key, item.Value);
                }

                Queue<string> waitingQueue = new Queue<string>();
                waitingQueue.Enqueue("Alice");
                waitingQueue.Enqueue("Bob");
                waitingQueue.Enqueue("Charlie");

                Console.WriteLine("Queue Example:");
                foreach (string person in waitingQueue)
                {
                    Console.WriteLine(person);
                }

                Stack<string> nameStack = new Stack<string>();
                nameStack.Push("Alice");
                nameStack.Push("Bob");
                nameStack.Push("Charlie");

                Console.WriteLine("Stack Example:");
                foreach (string name in nameStack)
                {
                    Console.WriteLine(name);
                }
            }
        }

    }
}
