// C# program to generate sequence of numbers within a range - get the even number and the squared numbers

int[] numbers = { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9 };

// get the even number
var evenNumber = numbers.Where(x => x % 2 == 0);
var squaredNumber = numbers.Select(x => x * x);

foreach (var item in evenNumber)
{
    Console.WriteLine(item);
}

foreach(var item in squaredNumber)
{
    Console.WriteLine(item);
}
