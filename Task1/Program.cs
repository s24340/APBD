
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 10, 101, 1 };
        double average = CalculateAverageConflict(numbers);
        Console.WriteLine("Średnia wartość: " + average);
        Console.WriteLine("Maksymalna wartość: " + MaxInt(numbers));
    }

    static double CalculateAverageConflict(int[] numbers)
    {
        int sum = 0;
        for (int z = 0; z < numbers.Length; z++)
        {
            sum = sum + numbers[z];
        }
        return (double)sum / numbers.Length;
    }
    static int MaxInt(int[] numbers)
    {
        int max = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
}