namespace learn_cs.src
{
    public class Loops
    {
        public void ForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void WhileLoop()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

        }

        public void DoWhileLoop()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);

        }

        public void ForEachLoop()
        {
            string[] colors = { "red", "green", "blue" };
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

        }
    }
}