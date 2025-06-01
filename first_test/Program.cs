using System.Text.RegularExpressions;

class Program
{
    public static void Main()
    {
        
            string input = " t ";
            string pattern = @"\s{1}";
        

            bool isMobile = Regex.IsMatch(input, pattern);

            Console.WriteLine(isMobile);  
        
    }
}