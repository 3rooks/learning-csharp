using System.Threading;

namespace learn_cs.src
{
    public class Threads
    {
        public class ThreadsExample
        {
            static void Main(string[] args)
            {
                Thread thread = new Thread(StartCounting);
                thread.Start();

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Thread Main: {i}");
                    Thread.Sleep(500);
                }

                Console.ReadLine();
            }

            static void StartCounting()
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine($"Thread Secondary: {i}");
                    Thread.Sleep(500);
                }
            }

        }

    }
}