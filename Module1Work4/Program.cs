using System;

namespace Module1Work4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfElements = TakeNumberOfElements();

            int[] firstArray = new int[numberOfElements];
            int evenCount = 0;
            var rand = new Random();

            for (int i = 0; i < numberOfElements; i++)
            {
                firstArray[i] = rand.Next(97, 122);

                if (firstArray[i] % 2 == 0)
                {
                    evenCount++;
                }
            }
        }

        public static int TakeNumberOfElements()
        {
            Console.WriteLine("Enter total number of elements:");

            int numberOfElements = 0;
            while (numberOfElements <= 0)
            {
                int.TryParse(Console.ReadLine(), out numberOfElements);
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Total number of elements = {numberOfElements} ");
            Console.ResetColor();

            return numberOfElements;
        }

        private void ArrayDivision()
        {
        }
    }
}
