// this is a c# program to generate sequence of numbers within a range - get  the even number and then the squared numbers too

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// examples of using Enumerable extension methods

var evenNumbers = numbers.Where(n => n % 2 == 0);
var squaredNumbers = numbers.Select(x => x * x);

foreach (var item in evenNumbers)
{
    Console.WriteLine(item);
}

foreach (var item in squaredNumbers)
{
    Console.WriteLine(item);
}