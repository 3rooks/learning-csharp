namespace learn_cs.src
{
    public class Arrays
    {
        public void SimpleArray()
        {
            int[] numbers = new int[5];

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public void ArrayInitialization()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void MultidimensionalArray()
        {
            int[,] matrix = new int[3, 3];

            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;
            matrix[2, 0] = 7;
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void JaggedArray()
        {
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };

            foreach (int[] subArray in jaggedArray)
            {
                foreach (int number in subArray)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
