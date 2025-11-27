// Make point class with mutable properties and multiple constructors, then create instances

Point a = new(2, 3);
Point b = new(-4, 0);

Console.WriteLine($"Point A: ({a._x}, {a._y})");
Console.WriteLine($"Point B: ({b._x}, {b._y})");
Console.WriteLine($"Point C (default): ({new Point()._x}, {new Point()._y})");

public class Point (int x, int y)
{
    public int _x = x;
    public int _y = y;

    public Point() :this(0, 0) { }
}