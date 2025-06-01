using System.Text.RegularExpressions;

class Program
{
    public static void Main()
    {
        
            string input = "1234567890";
            string pattern = @"\d{10}";
        

            bool isMobile = Regex.IsMatch(input, pattern);

            Console.WriteLine(isMobile);  
        
    }
}