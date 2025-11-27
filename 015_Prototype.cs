// Use while loops to create a number guessing game between a "pilot" and a "hunter".

int number;
Console.Write("Pilot, enter a number: ");
number = int.Parse(Console.ReadLine());

while (number < 0 || number > 100)
{
    Console.Write("Invalid input. Enter a number between 0 and 100: ");
    number = int.Parse(Console.ReadLine());
}

Console.Clear();
Console.Write("Hunter, guess the number between 0 and 100: ");
int guess = int.Parse(Console.ReadLine());

while (guess != number)
{
    if (guess < number)
    {
        Console.Write("Too low. Try again: ");
    }
    else
    {
        Console.Write("Too high. Try again: ");
    }
    guess = int.Parse(Console.ReadLine());
}
Console.WriteLine("Congratulations hunter! You guessed the number!");