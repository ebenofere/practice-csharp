// This is a C# program to generate sequence of numbers within a range

IEnumerable<int> GenerateNumber = new List<int> { 1, 3, 4, 5, 6, 7, 8, 9 };
foreach (int n in GenerateNumber)
{
    Console.WriteLine(n);
}