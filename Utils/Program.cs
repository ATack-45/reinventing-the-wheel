// See https://aka.ms/new-console-template for more information
/* stringUtils test cases
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
int[] testEncode = MyUtilities.StringUtils.Encode("hello");
foreach(int num in testEncode){
    System.Console.WriteLine(num);
}
System.Console.WriteLine(MyUtilities.StringUtils.Decode(testEncode));
*/



/* arrayUtils test cases
double[] doubleArr = {5.6,4.7,4,2};
int[] intArr = {2,6,9,4,2};
System.Console.WriteLine(MyUtilities.ArrayUtils.Average(doubleArr));
System.Console.WriteLine(MyUtilities.ArrayUtils.Average(intArr));
System.Console.WriteLine("");

System.Console.WriteLine(MyUtilities.ArrayUtils.Max(doubleArr));
System.Console.WriteLine(MyUtilities.ArrayUtils.Max(intArr));
System.Console.WriteLine("");

System.Console.WriteLine(MyUtilities.ArrayUtils.Min(doubleArr));
System.Console.WriteLine(MyUtilities.ArrayUtils.Min(intArr));
System.Console.WriteLine("");

double[] sortedDouble = MyUtilities.ArrayUtils.SortAscending(doubleArr);
foreach (double num in sortedDouble) { System.Console.Write(num + " ");}
System.Console.WriteLine("");
int[] sortedInt = MyUtilities.ArrayUtils.SortAscending(intArr);
foreach (int num in sortedInt) { System.Console.Write(num + " ");}
System.Console.WriteLine("");
System.Console.WriteLine("");

// sort decending
double[] sortedDecendingDouble = MyUtilities.ArrayUtils.SortDecending(doubleArr);
foreach (double num in sortedDecendingDouble) { System.Console.Write(num + " ");}
System.Console.WriteLine("");
int[] sortedDecendingInt = MyUtilities.ArrayUtils.SortDecending(intArr);
foreach (int num in sortedDecendingInt) { System.Console.Write(num + " ");}
System.Console.WriteLine("");
System.Console.WriteLine("");

System.Console.WriteLine(MyUtilities.ArrayUtils.Sum(doubleArr));
System.Console.WriteLine(MyUtilities.ArrayUtils.Sum(intArr));
System.Console.WriteLine("");

System.Console.WriteLine(MyUtilities.ArrayUtils.Product(doubleArr));
System.Console.WriteLine(MyUtilities.ArrayUtils.Product(intArr));
System.Console.WriteLine("");

System.Console.WriteLine(MyUtilities.ArrayUtils.Length(doubleArr));
System.Console.WriteLine(MyUtilities.ArrayUtils.Length(intArr));
System.Console.WriteLine("");

//reverse arrays
double[] ReverseDouble = MyUtilities.ArrayUtils.Reverse(doubleArr);
foreach (double num in ReverseDouble) { System.Console.Write(num + " ");}
System.Console.WriteLine("");
int[] ReverseInt = MyUtilities.ArrayUtils.Reverse(intArr);
foreach (int num in ReverseInt) { System.Console.Write(num + " ");}
System.Console.WriteLine("");
System.Console.WriteLine("");

double[] ClearedDouble = MyUtilities.ArrayUtils.Clear(doubleArr, 1,3);
foreach (double num in ClearedDouble) { System.Console.Write(num + " ");}
System.Console.WriteLine("");
int[] ClearedInt = MyUtilities.ArrayUtils.Clear(intArr);
foreach (int num in ClearedInt) { System.Console.Write(num + " ");}
System.Console.WriteLine("");
System.Console.WriteLine("");


// MUST comment out all cleared, reversed and SortDecending code to work
foreach (int num in intArr) { System.Console.Write(num + " ");}
System.Console.WriteLine("");
foreach(double num in doubleArr) {System.Console.Write(num + " ");}
System.Console.WriteLine("");
System.Console.WriteLine(MyUtilities.ArrayUtils.IndexOf(intArr, 6));
System.Console.WriteLine(MyUtilities.ArrayUtils.IndexOf(doubleArr,5.6));
*/


System.Console.WriteLine(MyUtilities.MathUtils.Power(2, 3));
System.Console.WriteLine("");

System.Console.WriteLine(MyUtilities.MathUtils.Abs(-14));
System.Console.WriteLine(MyUtilities.MathUtils.Abs(-15.5));
System.Console.WriteLine(MyUtilities.MathUtils.Abs(-15.2f));
System.Console.WriteLine("");

System.Console.WriteLine(MyUtilities.MathUtils.Min(1,5));
System.Console.WriteLine(MyUtilities.MathUtils.Min(6.2,5.3));
System.Console.WriteLine(MyUtilities.MathUtils.Min(3f,2f));
System.Console.WriteLine("");

System.Console.WriteLine(MyUtilities.MathUtils.Max(1,5));
System.Console.WriteLine(MyUtilities.MathUtils.Max(6.2,5.3));
System.Console.WriteLine(MyUtilities.MathUtils.Max(3f,2f));
System.Console.WriteLine("");

System.Console.WriteLine(MyUtilities.MathUtils.Add(1,5));
System.Console.WriteLine(MyUtilities.MathUtils.Add(6.2,5.3));
System.Console.WriteLine(MyUtilities.MathUtils.Add(3f,2f));
System.Console.WriteLine("");

System.Console.WriteLine(MyUtilities.MathUtils.Subtract(1,5));
System.Console.WriteLine(MyUtilities.MathUtils.Subtract(6.2,5.3));
System.Console.WriteLine(MyUtilities.MathUtils.Subtract(3f,2f));
System.Console.WriteLine("");

System.Console.WriteLine(MyUtilities.MathUtils.Multiply(1,5));
System.Console.WriteLine(MyUtilities.MathUtils.Multiply(6.2,5.3));
System.Console.WriteLine(MyUtilities.MathUtils.Multiply(3f,2f));
System.Console.WriteLine("");

System.Console.WriteLine(MyUtilities.MathUtils.Divide(1,5));
System.Console.WriteLine(MyUtilities.MathUtils.Divide(6.2,5.3));
System.Console.WriteLine(MyUtilities.MathUtils.Divide(3f,2f));
System.Console.WriteLine("");

System.Console.WriteLine(MyUtilities.MathUtils.Round(7.5));
System.Console.WriteLine(MyUtilities.MathUtils.Round(7.4M));
System.Console.WriteLine(MyUtilities.MathUtils.Round(7.7f));
System.Console.WriteLine("");

System.Console.WriteLine(MyUtilities.MathUtils.Celling(4.2));
System.Console.WriteLine(MyUtilities.MathUtils.Celling(4.2M));
System.Console.WriteLine(MyUtilities.MathUtils.Celling(4.2f));
System.Console.WriteLine("");

System.Console.WriteLine(MyUtilities.MathUtils.Floor(4.2));
System.Console.WriteLine(MyUtilities.MathUtils.Floor(4.2M));
System.Console.WriteLine(MyUtilities.MathUtils.Floor(4.2f));
System.Console.WriteLine("");

System.Console.WriteLine(MyUtilities.MathUtils.Average(4, 7));
System.Console.WriteLine(MyUtilities.MathUtils.Average(4.2, 7.6));
System.Console.WriteLine(MyUtilities.MathUtils.Average(4.2f, 9.6f));
System.Console.WriteLine("");






