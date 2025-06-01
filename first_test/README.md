# Basic Regex Usage
```CSharp
using System.Text.RegularExpressions;

string pattern = @"^\d{3}-\d{2}-\d{4}$"; // Social Security Number pattern
string input = "123-45-6789";

bool isMatch = Regex.IsMatch(input, pattern);
Console.WriteLine($"Is valid SSN: {isMatch}");
```