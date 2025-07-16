// See https://aka.ms/new-console-template for more information
using System.Data.SqlTypes;

public class MyClass
{
    public static void Main(string[] args)
    {
        Console.Write("Số lượng tiền cho vay: ");
        double deposit = Convert.ToDouble(Console.ReadLine());
        Console.Write("Tỉ lệ lãi suất theo tháng ");
        double interest_rate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Số tháng cho vay: ");
        int month = Convert.ToInt32(Console.ReadLine());

        //Tinh lai don:

        double total_interest = 0;

        for (int i = 0; i < month; i++)
        {
            total_interest += deposit * (interest_rate / 100) / 12;
        }

        Console.WriteLine($"Lãi đơn: Tổng số tiền lời sau {month} tháng là: {total_interest}");
    }
}
