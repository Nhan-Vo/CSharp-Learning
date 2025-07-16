using System.Formats.Asn1;
using System.Net;
using System.Runtime.InteropServices;

public class shaper
{
    public static void Main(string[] args)
    {
        bool status = true;
        do
        {
            Console.Write("1. Print the rectangle\n2. Print the square triangle (The corner is square at 4 different angles: top-left, top-right, botton-left, botton-right)\n3. Print isosceles triangle\n4. Exit\nEnter an option:");
            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 4)
            {
                status = false;
            }
            else if (option == 1)
            {
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= 5; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.Write("\n");
                }
                ;
            }
            else if (option == 2)
            {
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.Write("\n");
                }
                ;
            }
            else if (option == 3)
            {
                for (int i = 7; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.Write("\n");
                }
            }

        } while (status == true);
        

    }
}