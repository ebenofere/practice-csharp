// C# program to get a number and tell if it is a palindrome or not

int num, temp, reverse = 0, remainder;
Console.WriteLine("Enter a number : ");
num = int.Parse(Console.ReadLine());
temp = num;

while (num > 0)
{
    remainder = num % 10;
    reverse = (reverse * 10) + remainder;
    num = num / 10;
}

Console.WriteLine($"the number you entered is {temp}");
Console.WriteLine($"the reverse is {reverse}");

if (temp == reverse)
{
    Console.WriteLine("the number you entered is a palindrome");
}
else
{
    Console.WriteLine("the number you entered is not a palindrome");
}
Console.ReadLine();