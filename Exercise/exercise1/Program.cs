public class Exercise1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Math grade:");
        double mathGrade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Chemistry grade:");
        double scienceGrade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Physics grade:");
        double englishGrade = Convert.ToInt32(Console.ReadLine());

        double average = (mathGrade + scienceGrade + englishGrade) / 3;
        Console.WriteLine($"The average of Math, Chemistry, and Physics grades is: {average:F2}.");
    }
}