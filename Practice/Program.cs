// C# program to swap two numbers

int a, b, temp;
Console.WriteLine("Enter the first number");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
b = Convert.ToInt32(Console.ReadLine());
temp = a;
a = b;
b = temp;
Console.WriteLine($"after the swap, a is {a} and b is {b}");