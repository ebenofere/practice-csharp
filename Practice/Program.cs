// this is a c# program to generate sequence of numbers within a range - get the even number and then the squared numbers too

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//get the even number
var evenNumbers = numbers.Where(item => item % 2 == 0);
var squaredNumbers = numbers.Select(item => item * item);

foreach(int n in evenNumbers)
{
    Console.WriteLine(n);
}

foreach(int n in squaredNumbers)
{
    Console.WriteLine(n);
}