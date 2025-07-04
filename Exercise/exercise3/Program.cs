//chúng ta cho phép nhập vào các giá trị a1, a2, a3...ai.. với i < n. Trong đó n là số lượng các số trong dãy. Sau đó, chúng ta thực hiện việc so sánh để tìm ra giá trị lớn nhất và hiển thị giá trị đó.

public class Example3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap so luong cac so trong day (n):");
        int n = Convert.ToInt32(Console.ReadLine());
        int max = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap so thu {i + 1}:");
            int NewNumber = Convert.ToInt32(Console.ReadLine());

            if (NewNumber > max)
            {
                max = NewNumber;
            }

            if (i == n - 1)
            {
                Console.WriteLine($"So lon nhat trong day la: {max}");
            }
        }
    }
}
