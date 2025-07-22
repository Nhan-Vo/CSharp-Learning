public class MyList
{
    public static void Main(string[] args)
    {
        List<String> myList = new List<String>();
        myList.Add("Orange");
        myList.Add("Banana");
        myList.Add("Lemon");

        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }
        for (var i = 0; i < myList.Count; i++)
        {
            Console.WriteLine(i);
        }
    }
}