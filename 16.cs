// for numbers 0 to 100, print "Electric" in yellow for multiples of 5,
// "Fire" in red for multiples of 3, and "Electric and Fire" in blue for multiples of both 3 and 5.

for (int i = 0; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{i} Electric and Fire");
        Console.ResetColor();
    }
    else if (i % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{i} Fire");
        Console.ResetColor();
    }
    else if (i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{i} Electric");
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine($"{i} Normal");
    }
}