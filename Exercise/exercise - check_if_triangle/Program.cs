public class main
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the sides length:");
        Console.Write($"Enter side AB: ");
        double AB = Convert.ToDouble(Console.ReadLine());
        Console.Write($"Enter side BC: ");
        double BC = Convert.ToDouble(Console.ReadLine());
        Console.Write($"Enter side CA: ");
        double CA = Convert.ToDouble(Console.ReadLine());
        if ((AB < BC + CA) && (BC < CA + AB) && (CA < AB + BC))
        {
            Console.WriteLine($"It is possible to create a triangle with 3 sides:\nAB: {AB}\nBC: {BC}\nCA: {CA}");
        }
        else
        {
            Console.WriteLine($"It is NOT possible to create a triangle with 3 sides:\nAB: {AB}\nBC: {BC}\nCA: {CA}");
        }
    }
}