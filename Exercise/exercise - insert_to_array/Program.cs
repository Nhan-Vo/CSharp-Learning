using System.Globalization;

public class insert_to_array
{
    public static void Main(string[] args)
    {
        int[] myarray = { 10, 4, 6, 7, 8, 0, 0, 0, 0, 0 };
        Console.Write("Enter a number to insert into the array:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a positon (from 1-10) to insert into the array:");
        int position = Convert.ToInt32(Console.ReadLine());
        int newvalue = 0;

        if (position < 1 || position > 10)
        {
            Console.WriteLine("Invalid postion. Please enter a position between 1 and 10.");
            return;
        }
        
        //when a position is entered, if the current value is occupied,


    }
}