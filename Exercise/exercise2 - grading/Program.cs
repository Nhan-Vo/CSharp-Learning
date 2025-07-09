public class Exercise2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Math grade:");
        double mathGrade = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Chemistry grade:");
        double scienceGrade = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Physics grade:");
        double englishGrade = Convert.ToDouble(Console.ReadLine());

        double average = (mathGrade + scienceGrade + englishGrade) / 3;
        Console.WriteLine($"The average of Math, Chemistry, and Physics grades is: {average:F2}.");

        switch (average)
        {
            case >= 75:
                Console.WriteLine("Grade: A");
                break;
            case >= 60:
                Console.WriteLine("Grade: B");
                break;
            case >= 45:
                Console.WriteLine("Grade: C");
                break;
            case >= 35:
                Console.WriteLine("Grade: D");
                break;
            case < 35:
                Console.WriteLine("Grade: E");
                break;
        }
    }
}