public class CalculateAreaOfRect
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter height: ");
        double heigth = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter width: ");
        double width = Convert.ToDouble(Console.ReadLine());
        double area = heigth * width;
        Console.WriteLine("Area is: " + area);
    }
}