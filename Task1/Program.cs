
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 10, 101, 1 };
        double average = CalculateAverage(numbers);
        Console.WriteLine("Średnia wartość: " + average);
        Console.WriteLine("Maksymalna wartość: " + MaxInt(numbers));
    }

    static double CalculateAverage(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum = sum + numbers[i];
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