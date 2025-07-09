public class Leap_year_checker
{
    public static void Main(string[] args)
    {
        Console.Write("Please enter the year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        {
            Console.WriteLine($"---------------------\n{year} is a leap year");
        }
        else
        {
            Console.WriteLine($"---------------------\n{year} is not a leap year");
        };

        // for (int year = 1900; year <= 2100; year++)
        // {
        //     if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        //     {
        //         Console.WriteLine($"---------------------\n{year} is a leap year");
        //     }
        // }
    }
}