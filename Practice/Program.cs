// C# Program to check whether the entered number is even or odd

int i;
Console.WriteLine("enter a number : ");
i = int.Parse(Console.ReadLine());
if (i % 2 == 0)
{
    Console.WriteLine("the entered number is an even number");
    Console.Read();
}
else
{
    Console.WriteLine("the entered number is an odd number");
    Console.Read();
}