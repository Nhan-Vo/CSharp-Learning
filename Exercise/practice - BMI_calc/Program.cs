public class BMI_Calc
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter height (Meters) and weight (Kilograms):");
        Console.Write("Height = ");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.Write("Weight = ");
        double weight = Convert.ToDouble(Console.ReadLine());
        double BMI = weight / (height * height);
        switch (BMI)
        {
            case < 18.5:
                Console.WriteLine($"BMI = {BMI:F2} -> Underweight");
                break;
            case < 25:
                Console.WriteLine($"BMI = {BMI:F2} -> Normal");
                break;
            case < 30:
                Console.WriteLine($"BMI = {BMI:F2} -> Overweight");
                break;
            case >= 30:
                Console.WriteLine($"BMI = {BMI:F2} -> Obese");
                break;
        }
    }
}