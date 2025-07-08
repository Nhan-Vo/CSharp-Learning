public class calculate_current_time
{
    public static void Main(string[] args)
    {
        DateTime localDate = DateTime.Now;
        Console.WriteLine("Datetime Now is : " + localDate);
        Console.WriteLine($"{localDate.Hour}{localDate.Minute}{localDate.Second}");
    }
}

