using System;

namespace Module1Work4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfElements = TakeNumberOfElements();

            string[] generalArray = new string[numberOfElements];
            int evenCount = 0;

            var rand = new Random();

            for (int i = 0; i < numberOfElements; i++)
            {
                generalArray[i] = rand.Next(97, 122).ToString();

                if (int.Parse(generalArray[i]) % 2 == 0)
                {
                    evenCount++;
                }
            }

            DistributionAndEncoding(generalArray, evenCount, numberOfElements);
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

        private static void DistributionAndEncoding(string[] generalArray, int evenCount, int numberOfElements)
        {
            int unevenCount = numberOfElements - evenCount;

            string[] arrayOfEven = new string[evenCount];
            string[] arrayOfUneven = new string[unevenCount];

            int e = 0;
            int u = 0;
            int countE = 0;
            int countU = 0;

            for (int i = 0; i < generalArray.Length; i++)
            {
                int element = int.Parse(generalArray[i]);

                if (element % 2 == 0)
                {
                    arrayOfEven[e] = Convert.ToChar(element).ToString();

                    if (SearchChar(arrayOfEven[e].ToString()))
                    {
                        arrayOfEven[e] = arrayOfEven[e].ToUpper();
                        countE++;
                    }

                    e++;
                }
                else
                {
                    arrayOfUneven[u] = Convert.ToChar(element).ToString();

                    if (SearchChar(arrayOfUneven[u].ToString()))
                    {
                        arrayOfUneven[u] = arrayOfUneven[u].ToUpper();
                        countU++;
                    }

                    u++;
                }
            }

            PrintResults(arrayOfEven, arrayOfUneven, countE, countU);
        }

        private static bool SearchChar(string str)
        {
            string[] strArray = { "a", "e", "i", "d", "h", "j" };

            for (int i = 0; i < strArray.Length; i++)
            {
                if (str == strArray[i])
                {
                    return true;
                }
            }

            return false;
        }

        private static void PrintResults(string[] arrayOfEven, string[] arrayOfUneven, int countE, int countU)
        {
            string result = countE > countU ? $"Uppercase letters more in the first array - ({countE}/{countU})" :
                $"Uppercase letters more in the second array - ({countE}/{countU})";

            Console.WriteLine(result);

            Console.WriteLine("1. Array of even:");
            for (int i = 0; i < arrayOfEven.Length; i++)
            {
                Console.Write($"{arrayOfEven[i]} ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("2. Array of uneven:");
            for (int i = 0; i < arrayOfUneven.Length; i++)
            {
                Console.Write($"{arrayOfUneven[i]} ");
            }

            Console.WriteLine();
        }
    }
}
