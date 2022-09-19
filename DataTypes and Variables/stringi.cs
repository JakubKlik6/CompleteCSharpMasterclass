string something, something2;
Console.Write("Please enter your name and press enter");
something = Convert.ToString(Console.ReadLine());

Console.WriteLine(something);
Console.WriteLine("");

Console.WriteLine("Uppercase");
Console.WriteLine(something.ToUpper());

Console.WriteLine("Lowercase");
Console.WriteLine(something.ToLower());

Console.WriteLine("No trim");
Console.WriteLine(something.Trim());

Console.ReadKey(true);
