public class LinearEquationResolver
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Given equation 'a*x + b = 0', please enter:");

        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());

        if (a != 0)
        {
            double x = -b / a;
            Console.WriteLine($"x = {x:F2}");
        }
        else
        {
            if (b == 0)
            {
                Console.WriteLine("The equation is right with any x");
            }
            else
            {
                Console.WriteLine("No possible solution"); 
            }
        }
        ;
    }
}