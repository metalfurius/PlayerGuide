// Make point class with mutable properties and multiple constructors, then create instances

Point a = new(2, 3);
Point b = new(-4, 0);

Console.WriteLine($"Point A: ({a.X}, {a.Y})");
Console.WriteLine($"Point B: ({b.X}, {b.Y})");
Console.WriteLine($"Point C (default): ({new Point().X}, {new Point().Y})");

public class Point (int x, int y)
{
    public int X = x;
    public int Y = y;

    public Point() :this(0, 0) { }
}