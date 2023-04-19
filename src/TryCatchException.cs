namespace learn_cs.src
{
    public class TryCatchException
    {
        public void TryCatchCase()
        {
            try
            {
                int a = 10;
                int b = 0;
                int result = a / b;
                Console.WriteLine("The result is: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            Console.WriteLine("Program execution finished.");
        }
    }
}