// C# program to generate sequence of numbers within a range - get the even number and the squared numbers

int[] numberList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
var evenArray = numberList.Where(x => x % 2 == 0);
var squaredArray = numberList.Select(x => x * x);
//foreach(int item in evenArray)
//{
//    Console.WriteLine(item);
//}
foreach (int item in squaredArray)
{
    Console.WriteLine(item);
}