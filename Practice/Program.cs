// C# program to accept a number from the user and display it if it is positive

Console.WriteLine("Enter a number : ");
int enteredNumber = Convert.ToInt32(Console.ReadLine());

if (enteredNumber > 0)
{
    Console.WriteLine("The entered number is positive");
}
else if (enteredNumber == 0)
{
    Console.WriteLine("The entered number is zero");
}
else
{
    Console.WriteLine("The enteredd number is negative");
}
Console.ReadLine();