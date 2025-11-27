// Determine if a number is even or odd
Console.WriteLine("Enter number: ");
string numberInput = Console.ReadLine();
int number = int.Parse(numberInput);

if (number % 2 == 0)
{
    Console.WriteLine("The number is even.");
}
else
{
    Console.WriteLine("The number is odd.");
}