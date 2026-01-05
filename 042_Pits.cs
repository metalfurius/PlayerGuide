ConsoleMethods.Writeline("What size of game do you want to play? (Small, Medium, Large)");
Size size = Console.ReadLine()?.ToLower() switch
{
    "medium" => Size.Medium,
    "large" => Size.Large,
    _ => Size.Small
};

Game game = new Game(size);
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
    if (currentRoom == Room.PitRoom)
    {
        ConsoleMethods.Writeline("You have fallen into a pit! Game over.", ConsoleColor.Red);
        break;
    }
    else
    {
        var (x, y) = game.GetCurrentCoordinates();
        ConsoleMethods.Writeline($"You are in the {currentRoom} room."+" Current coordinates: ("+x+", "+y+")");
        if(game.checkPitRoomAdjacent())
        {
            ConsoleMethods.Writeline("You feel a draft. There is a pit in a nearby room", ConsoleColor.Yellow);
        }
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
public class Game (Size size)
{
    private bool fountainEnabled = false;
    private int x = 0;
    private int y = 0;

    public Room GetCurrentRoom()
    {
        int mapSize = size == Size.Small ? 4 : size == Size.Medium ? 6 : 8;
        if (x < 0 || x >= mapSize || y < 0 || y >= mapSize)
        {
            return Room.OffMap;
        }
        if (x == 0 && y == 0)
        {
            return Room.Entrance;
        }
        
        (int x, int y) fountainLocation = size switch
        {
            Size.Small => (0, 2),
            Size.Medium => (2, 4),
            Size.Large => (4, 6),
            _ => (0, 2)
        };

        if (x == fountainLocation.x && y == fountainLocation.y)
        {
            return Room.Fountain;
        }

        if (x == 3 && y == 3)
        {
            return Room.PitRoom;
        }
        return Room.Empty;
    }
    public bool checkPitRoomAdjacent()
    {
        foreach (Room room in GetAdjacentRooms())
        {
            if (room == Room.PitRoom)
            {
                return true;
            }
        }
        return false;
    }
    public List<Room> GetAdjacentRooms()
    {
        (int newX, int newY) = GetCurrentCoordinates();
        List<Room> adjacentRooms = new List<Room>();
        foreach (Direction direction in Enum.GetValues(typeof(Direction)))
        {
            newX = x;
            newY = y;
            switch (direction)
            {
                case Direction.North:
                    newY += 1;
                    break;
                case Direction.South:
                    newY -= 1;
                    break;
                case Direction.East:
                    newX += 1;
                    break;
                case Direction.West:
                    newX -= 1;
                    break;
            }
            Game tempGame = new Game(size);
            tempGame.x = newX;
            tempGame.y = newY;
            adjacentRooms.Add(tempGame.GetCurrentRoom());
        }
        return adjacentRooms;
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
    OffMap,
    PitRoom
}
public enum Size
{
    Small,
    Medium,
    Large
}