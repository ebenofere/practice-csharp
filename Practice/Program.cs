// C# program to get a sum and display the sum of the digits

int num, r, Sum = 0;
Console.WriteLine("Enter a number :");
num = int.Parse(Console.ReadLine());

while (num != 0)
{
    r = num % 10;
    num = num / 10; // integers don't have decimals
    Sum += r;
}

Console.WriteLine($"the total of the individual digits is : {Sum}");