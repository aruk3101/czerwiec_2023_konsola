namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumbers = GenerateRandomNumbers(100);

            BubbleSort(randomNumbers);

            Console.WriteLine("Tablica po sortowaniu:");
            Console.WriteLine(string.Join(", ", randomNumbers));
        }

        static int[] GenerateRandomNumbers(int size)
        {
            Random random = new Random();
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(1, 101);
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
