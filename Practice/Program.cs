// C# program to find greatest among 2 numbers
int a, b;
Console.WriteLine("Enter the first number : ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number : ");
b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("a is greater than b");
}
else if (a == b)
{
    Console.WriteLine("both are equal");
}
else
{
    Console.WriteLine("b is greater than a");
}