// Number Guessing Game between Pilot and Hunter with methods

    int AskForNumber(string prompt)
    {
        Console.Write(prompt + ": ");
        return int.Parse(Console.ReadLine());
    }

    int AskForNumberInRange(string prompt, int min, int max)
    {
        while (true)
        {
            int number = AskForNumber(prompt + $" (between {min} and {max})");
            if (number >= min && number <= max)
                return number;
        }
    }

    int number = AskForNumberInRange("Pilot, enter a number", 0, 100);
    Console.Clear();

    int guess = AskForNumber("Hunter, guess the number between 0 and 100");
    while (guess != number)
    {
        if (guess < number)
        {
            guess = AskForNumber("Too low. Try again");
        }
        else
        {
            guess = AskForNumber("Too high. Try again");
        }
    }
    Console.WriteLine("Congratulations! You guessed the number.");