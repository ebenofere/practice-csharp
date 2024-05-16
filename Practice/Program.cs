// This is a C# program to generate odd numbers within a range

IEnumerable<int> oddNums = Enumerable.Range(1, 51).Where(x => x % 2 != 0);

foreach (int n in oddNums)
{
    Console.WriteLine($"odd numbers: {n}");
}
Console.ReadLine();