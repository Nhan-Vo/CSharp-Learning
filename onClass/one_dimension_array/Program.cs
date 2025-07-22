public class LearnArray
{
    public static void Main(string[] args)
    {
        int[] myarray1 = { 1, 2, 3, 4, 5, 6 };
        int[] myarray2 = new int[] { 7, 8, 9, 10, 11 };
        Console.WriteLine(myarray1[0]);

        foreach (var item in myarray2)
        {
            Console.WriteLine(item);
        }

        for (var i = myarray1.Length; i > 0; i--)
        {
            Console.WriteLine(i);
        }

    }
}