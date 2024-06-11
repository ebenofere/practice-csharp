//C# Program to Find Sum of Digits of a Number using Recursion
int num, result;
Pro pg = new Pro();
Console.WriteLine("Enter the number : ");
num = int.Parse(Console.ReadLine());
result = pg.sum(num);
Console.WriteLine($"The sum of digits in {num} is {result}");
Console.ReadLine();

public class Pro
{
    public int sum(int num)
    {
        if (num != 0)
        {
            return (num % 10 + sum(num / 10));
        }
        else
        {
            return 0;
        }
    }
}
