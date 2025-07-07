public class Converter
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please choose an option:\n1. Convert VND to USD\n2. Convert USD to VND");
        Console.Write("Enter an option: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        if (number == 1)
        {
            Console.Write("-------------------------\nEnter the amount in VND: ");
            double vnd = Convert.ToDouble(Console.ReadLine());
            double usd = vnd / 23000;
            Console.WriteLine($"{vnd} VND = {usd} USD");
        }
        else if (number == 2)
        {
            Console.Write("-------------------------\nEnter the amount in USD: ");
            double usd = Convert.ToDouble(Console.ReadLine());
            double vnd = usd * 23000;
            Console.WriteLine($"{usd} USD = {vnd} VND");
        }
        else
        {
            Console.WriteLine("-------------------------\nInvalid option!");
        }
    }
}