// Manticore vs City Game

//Start
int manticoreHealth = 10;
int cityHealth = 15;
int round = 1;

int distance = AskForNumberInRange("First player, enter the distance of the Manticore from the city", 0, 100);
Console.Clear();

Info("Player two, you have 15 rounds to destroy the Manticore before it reaches the city!");

while (manticoreHealth > 0 && cityHealth > 0)
{
    //Round status
    Info("----------------------------------------------------------------------------------------");
    Status(manticoreHealth, cityHealth, round);

    //Damage this round
    int damage = DamageThisRound(round);

    //Player two's turn to shoot
    int shotDistance = AskForNumberInRange("Enter the distance to fire your cannon", 0, 100);
    DisplayRangeHint(shotDistance, distance);

    if (shotDistance == distance)
    {
        manticoreHealth -= damage;
        if (manticoreHealth <= 0)
        {
            Info("The Manticore has been destroyed! The city is saved!");
        }
    }
    
    cityHealth -= 1;
    if (cityHealth <= 0)
    {
        Info("The city has been destroyed! The Manticore reigns supreme!");
    }
    
    
    round++;
}

int AskForNumber(string prompt)
{
    Input(prompt + ": ");
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

void Info (string message)
{
    Console.WriteLine(message);
}

void Input (string message)
{
    Console.Write(message);
}

void Status (int manticoreHealth, int cityHealth, int currentRound)
{
    Info($"STATUS: Round: {currentRound} City Health: {cityHealth} Manticore Health: {manticoreHealth}");
}

int DamageThisRound (int roundNumber)
{
    if (roundNumber % 3 == 0 && roundNumber % 5 == 0)
    {
        Info("The cannonball is expected to explode with a thunderous boom! (10 damage)");
        return 10;
    }
    else if (roundNumber % 3 == 0)
    {
        Info("The cannonball is expected to soar through the air and hit its target with a fiery impact! (3 damage)");
        return 3;
    }
    else if (roundNumber % 5 == 0)
    {
        Info("The cannonball is expected to whistle through the air and strike true! (3 damage)");
        return 3;
    }
    else
    {
        Info("The cannonball is expected to land with a dull thud, missing its mark. (1 damage)");
        return 1;
    }
}

void DisplayRangeHint (int shotDistance, int manticoreDistance)
{
    if (shotDistance < manticoreDistance)
    {
        Info("Your shot was too short.");
    }
    else if (shotDistance > manticoreDistance)
    {
        Info("Your shot was too far.");
    }
    else
    {
        Info("Direct hit!");
    }
}