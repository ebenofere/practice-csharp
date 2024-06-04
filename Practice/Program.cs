// this is a c# program to generate odd numbers within a range
IEnumerable<int> oddNums = Enumerable.Range(1, 100).Where(x => x % 2 != 0);
foreach (int items in oddNums)
{
    Console.WriteLine(items);
}
Console.ReadLine();