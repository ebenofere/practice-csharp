//C# Program to Get a Number and Display the Number with its Reverse

int num, reverse = 0;
Console.WriteLine("enter the number : ");
num = int.Parse(Console.ReadLine());

while (num != 0)
{
    reverse = reverse * 10;
    reverse = reverse + (num % 10);
    num /= 10;
}

Console.WriteLine($"the reverse of the entered number is {reverse}");
Console.ReadLine();