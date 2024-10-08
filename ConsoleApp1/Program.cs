namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumbers = GenerateRandomNumbers(100);

           

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

    }
}
