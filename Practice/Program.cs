/// C# program to check whether a given number is even or odd

int a;
Console.WriteLine("enter the number : ");
a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("this number is even");
    Console.Read();
}
else
{
    Console.WriteLine("this number is odd");
    Console.Read();
}