// C# program to swap two numbers 
int num1, num2, temp;
Console.WriteLine("enter the first number");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter the second number");
num2 = int.Parse(Console.ReadLine());

temp = num1;
num1 = num2;
num2 = temp;

Console.WriteLine($"\nFirst number: {num1}");
Console.WriteLine($"\nSecond number: {num2}");
Console.Read();