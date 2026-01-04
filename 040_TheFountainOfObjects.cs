Game game = new Game();
while (true)
{
    ConsoleMethods.Clear();
    var currentRoom = game.GetCurrentRoom();
    if (currentRoom == Room.Entrance && game.isFountainEnabled)
    {
        ConsoleMethods.Writeline("You have returned to the entrance! You win!", ConsoleColor.Green);
        break;
    }
    if (currentRoom == Room.Fountain)
    {
        ConsoleMethods.Writeline("You have found the Fountain of Objects! You should enable it and run!", ConsoleColor.Green);
    }
    if (currentRoom == Room.OffMap)
    {
        ConsoleMethods.Writeline("You have wandered off the map! Game over.", ConsoleColor.Red);
        break;
    }
    else
    {
        var (x, y) = game.GetCurrentCoordinates();
        ConsoleMethods.Writeline($"You are in the {currentRoom} room."+" Current coordinates: ("+x+", "+y+")");
        ConsoleMethods.Writeline("Go in this direction (N/S/E/W) or enable the fountain (F):");
        var input = Console.ReadLine();
        if (input?.ToUpper() == "F" && game.GetCurrentRoom() != Room.Fountain)
        {
            ConsoleMethods.Writeline("You can only enable the fountain when you are in the Fountain room.", ConsoleColor.Yellow);
            Console.ReadKey(true);
        }
        else if (input?.ToUpper() == "F" && game.GetCurrentRoom() == Room.Fountain)
        {
            game.EnableFountain();
        }
        else
        {
            Direction? direction = input?.ToUpper() switch
            {
                "N" => Direction.North,
                "S" => Direction.South,
                "E" => Direction.East,
                "W" => Direction.West,
                _ => null
            };
            if (direction.HasValue)
            {
                game.Move(direction.Value);
            }
            else
            {
                ConsoleMethods.Writeline("Invalid direction. Please enter N, S, E, or W.", ConsoleColor.Yellow);
            }
        }
    }
}
public class Game
{
    private int x = 0;
    private int y = 0;
    private bool fountainEnabled = false;
    public Room GetCurrentRoom()
    {
        if (x < 0 || x > 3 || y < 0 || y > 3)
        {
            return Room.OffMap;
        }
        if (x == 0 && y == 0)
        {
            return Room.Entrance;
        }
        if (x == 2 && y == 0)
        {
            return Room.Fountain;
        }
        return Room.Empty;
    }
    public (int, int) GetCurrentCoordinates()
    {
        return (x, y);
    }
    public void Move(Direction direction)
    {
        switch (direction)
        {
            case Direction.North:
                y += 1;
                break;
            case Direction.South:
                y -= 1;
                break;
            case Direction.East:
                x += 1;
                break;
            case Direction.West:
                x -= 1;
                break;
        }
    }
    public void EnableFountain()
    {
        fountainEnabled = true;
        ConsoleMethods.Writeline("Fountain enabled! Run to the entrance!", ConsoleColor.Cyan);
    }
    public bool isFountainEnabled => fountainEnabled;
}

public static class ConsoleMethods
{
    public static void Writeline(string message, ConsoleColor color = ConsoleColor.White)
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ForegroundColor = previousColor;
    }
    public static void Write(string message, ConsoleColor color = ConsoleColor.White)
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.Write(message);
        Console.ForegroundColor = previousColor;
    }
    public static void Clear()
    {
        Console.Clear();
    }
}
public enum Direction
{
    North,
    South,
    East,
    West
}

public enum Room
{
    Empty,
    Entrance,
    Fountain,
    OffMap
}