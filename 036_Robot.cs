#nullable enable

Console.WriteLine("=== Robot Command Pattern ===");
Robot robot = new();
Console.WriteLine($"Robot initial state: ({robot.X}, {robot.Y}) - Powered: {robot.IsPowered})");
Console.WriteLine("Enter command 1 (On, Off, North, South, East, West): ");
string? command1 = Console.ReadLine();
robot.Commands[0] = command1 switch
{
    "On" => new OnCommand(),
    "Off" => new OffCommand(),
    "North" => new NorthCommand(),
    "South" => new SouthCommand(),
    "East" => new EastCommand(),
    "West" => new WestCommand(),
    _ => null
};
Console.WriteLine("Enter command 2 (On, Off, North, South, East, West): ");
string? command2 = Console.ReadLine();
robot.Commands[1] = command2 switch
{
    "On" => new OnCommand(),
    "Off" => new OffCommand(),
    "North" => new NorthCommand(),
    "South" => new SouthCommand(),
    "East" => new EastCommand(),
    "West" => new WestCommand(),
    _ => null
};
Console.WriteLine("Enter command 3 (On, Off, North, South, East, West): ");
string? command3 = Console.ReadLine();
robot.Commands[2] = command3 switch
{
    "On" => new OnCommand(),
    "Off" => new OffCommand(),
    "North" => new NorthCommand(),
    "South" => new SouthCommand(),
    "East" => new EastCommand(),
    "West" => new WestCommand(),
    _ => null
};
robot.Run();

public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public RobotCommand?[] Commands { get; } = new RobotCommand?[3];
    public void Run()
    {
        foreach(RobotCommand? command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"Robot ({X}, {Y}) - Powered: {IsPowered})");
        }  
    }
}

public abstract class RobotCommand
{
    public abstract void Run(Robot robot);
}

public class OnCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

public class NorthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y += 1;
        }
    }
}

public class SouthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y -= 1;
        }
    }
}

public class EastCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X += 1;
        }
    }
}

public class WestCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X -= 1;
        }
    }
}