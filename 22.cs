// Using enum to represent the state of a chest

Chest myChest = Chest.Locked;
while (true)
{
    Console.WriteLine($"The chest is currently {myChest}. What do you want to do?");
    Console.Write("Type a command (open, close, lock, unlock): ");
    string input = Console.ReadLine();

    if (myChest == Chest.Locked && input == "unlock") 
        myChest = Chest.Closed;
    else if (myChest == Chest.Closed && input == "open") 
        myChest = Chest.Opened;
    else if (myChest == Chest.Opened && input == "close") 
        myChest = Chest.Closed;
    else if (myChest == Chest.Closed && input == "lock") 
        myChest = Chest.Locked;
    else
    {
        Console.WriteLine("------------------------------------");
        Console.WriteLine("That is not a valid transition.");
        Console.WriteLine("------------------------------------");
    }
}

enum Chest
{
    Closed,
    Opened,
    Locked
}