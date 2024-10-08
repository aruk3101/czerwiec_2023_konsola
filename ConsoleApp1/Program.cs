namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumbers = GenerateRandomNumbers(100);

            Console.WriteLine("Tablica przed sortowaniem:");
            Console.WriteLine(string.Join(", ", randomNumbers));

            BubbleSort(randomNumbers);

            Console.WriteLine("\nTablica po sortowaniu:");
            Console.WriteLine(string.Join(", ", randomNumbers));

            bool test = true;
            for(int i = 0; i < randomNumbers.Length-1; i++)
            {
                if (randomNumbers[i] > randomNumbers[i + 1])
                {
                    test = false;
                    break;
                }
            }
            if (test == true)
            {
                Console.WriteLine("\nTest zdany");
            }
            else
            {
                Console.WriteLine("\nTest niezdany");
            }
        }

        static int[] GenerateRandomNumbers(int size)
        {
            Random random = new Random();
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(1, 1001);
            }

            return numbers;
        }

        static void BubbleSort(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
        }

    }
}
