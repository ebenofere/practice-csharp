// This is a C# program to generate sequence of numbers within a range
IEnumerable<int> GenerateNumber = new List<int> { 1, 2, 3, 5, 3, 2, 7, 8 };
foreach (int n in GenerateNumber)
{
    Console.WriteLine(n);
}