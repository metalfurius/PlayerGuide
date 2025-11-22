// Recursive Countdown

Countdown(10);

void Countdown(int number)
{
    if (number <= 0)
    {
        Console.WriteLine("Liftoff!");
    }
    else
    {
        Console.WriteLine(number);
        Countdown(number - 1);
    }
}
