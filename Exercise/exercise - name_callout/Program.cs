public class Name_callout
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Hello, Mr/Ms. Anonymous");
            return;
        }
        Console.WriteLine("Hello, " + name);
    }
}