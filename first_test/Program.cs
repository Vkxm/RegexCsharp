using System.Text.RegularExpressions;

class Program
{
    public static void Main()
    {
        string input = "Phone: 9876543210 and 1234567890";
        string pattern = @"\d{10}";

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match m in matches)
        {
            Console.WriteLine("Found: " + m.Value);
        }
    }
}