
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 10 };
        double average = CalculateAverage(numbers);
        Console.WriteLine("Średnia wartość: " + average);
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
}