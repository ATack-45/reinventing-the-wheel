// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string test = "hello";
string test2 = "HelLo";
string test3 = "olleh";
string test4 = "       Hello    !";
System.Console.WriteLine(MyUtilities.StringUtils.ToUpper(test));
System.Console.WriteLine(MyUtilities.StringUtils.ToLower(test2));
System.Console.WriteLine(MyUtilities.StringUtils.length(test));
System.Console.WriteLine(MyUtilities.StringUtils.Reverse(test3));
System.Console.WriteLine(MyUtilities.StringUtils.CountVowels(test));
System.Console.WriteLine(MyUtilities.StringUtils.CountConsonants(test));
System.Console.WriteLine(MyUtilities.StringUtils.HasLetter(test, 'o'));
System.Console.WriteLine(MyUtilities.StringUtils.ToCharArray(test));
System.Console.WriteLine(MyUtilities.StringUtils.Trim(test4));