public class Example
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the second number:");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        
        int sum = firstNumber + secondNumber;
        
        Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: {sum}");
    }
}


