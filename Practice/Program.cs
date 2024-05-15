// This is a C# program to generate odd numbers within a range

IEnumerable<int> oddNums = Enumerable.Range(1, 40).Where(x => x % 2 != 0);
foreach (int n in oddNums)
{
    Console.WriteLine(n);
}
Console.ReadLine();