using learn_cs.src;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Loops myLoops = new Loops();
            myLoops.ForLoop();
            myLoops.WhileLoop();
            myLoops.DoWhileLoop();
            myLoops.ForEachLoop();
        }
    }
}
