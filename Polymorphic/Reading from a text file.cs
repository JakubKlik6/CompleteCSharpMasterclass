//Example 1 of reading textx
string text = System.IO.File.ReadAllText(@"C:\Users\DELL\Desktop\blabla.txt");

Console.WriteLine($"Textfile contains following text: \n{text}");

string[] lines = System.IO.File.ReadAllLines(@"C:\Users\DELL\Desktop\blabla.txt");

Console.WriteLine("\nTextfile contains following text:");

foreach (string line in lines)
{
    Console.WriteLine("\t" + line);
}