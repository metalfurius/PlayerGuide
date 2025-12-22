int startingPassCode = AskForNumber("Enter a starting passcode for the door");
Door door = new Door(startingPassCode);

while (true)
{
    Console.WriteLine($"The door is currently {door.State}.");
    Console.WriteLine("Choose an action: 1) Open 2) Close 3) Lock 4) Unlock 5) Change Passcode 6) Exit");
    int choice = AskForNumber("Enter your choice");

    if (choice == 1)
    {
        door.Open();
    }
    else if (choice == 2)
    {
        door.Close();
    }
    else if (choice == 3)
    {
        door.Lock();
    }
    else if (choice == 4)
    {
        door.Unlock();
    }
    else if (choice == 5)
    {
        int oldPassCode = AskForNumber("Enter the old passcode");
        int newPassCode = AskForNumber("Enter the new passcode");
        door.changePassCode(oldPassCode, newPassCode);
    }
    else if (choice == 6)
    {
        break;
    }
}

static int AskForNumber(string prompt)
{
    Input(prompt + ": ");
    return int.Parse(Console.ReadLine());
}

static void Input (string message)
{
    Console.Write(message);
}

public class Door(int passCode)
{
    public DoorState State { get; set; } = DoorState.Closed;
    public int PassCode { get; set; } = passCode;

    public void Close()
    {
        if (State == DoorState.Open)
        {
            State = DoorState.Closed;
        }
    }

    public void Open()
    {
        if (State == DoorState.Closed)
        {
            State = DoorState.Open;
        }
    }

    public void Lock()
    {
        if (State == DoorState.Closed)
        {
            State = DoorState.Locked;
        }
    }

    public void Unlock()
    {
        if (State == DoorState.Locked)
        {
            State = DoorState.Closed;
        }
    }

    public void changePassCode(int oldPassCode, int newPassCode)
    {
        if (oldPassCode == PassCode)
        {
            Console.WriteLine("Passcode changed successfully.");
            PassCode = newPassCode;
        }
        else
        {
            Console.WriteLine("Incorrect old passcode. Passcode change failed.");
        }
    }
}
public enum DoorState
{
    Open,
    Closed,
    Locked
}