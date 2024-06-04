// this is a C# program numbers sequence of numbers within a range.
IEnumerable<int> oddNums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
foreach (int items in oddNums)
{
    Console.WriteLine(items);
}
Console.ReadLine();