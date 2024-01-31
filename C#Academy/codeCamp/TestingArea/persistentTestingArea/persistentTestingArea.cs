internal class Program
{
    private static void Main(string[] args)
    {
        // Variable Declaration
        string[] orderID = {"B123" , "C234" , "A345" , "C15" , "B177" , "G3003" , "C235" , "B179"};

        // Code
        foreach (string fraudID in orderID)
        {
            if (fraudID.StartsWith("B"))
            {
                Console.WriteLine($"ID {fraudID} needs to be investigated");
            }
        }

    }
}