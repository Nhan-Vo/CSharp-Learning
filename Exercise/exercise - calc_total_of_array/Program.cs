public class calc_total_of_array
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[5];
        numbers[0] = 2;
        numbers[1] = 5;
        numbers[2] = 9;
        numbers[3] = 6;
        numbers[4] = 7;
        Console.WriteLine("The numbers in the array are:");
        foreach (int number in numbers)
        {
            Console.Write($"{number}, ");
        }
        int total = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            total += numbers[i];
        }
        Console.WriteLine($"\n{total} is the total of the array");
    }
}