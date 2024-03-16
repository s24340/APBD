
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 10, 101, 1 };
        double average = CalculateAverageConfict(numbers);
        Console.WriteLine("Średnia wartość: " + average);
        Console.WriteLine("Maksymalna wartość: " + MaxInt(numbers));
    }

    static double CalculateAverageConfict(int[] numbers)
    {
        int sum = 0;
        for (int n = 0; n < numbers.Length; n++)
        {
            sum = sum + numbers[n];
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