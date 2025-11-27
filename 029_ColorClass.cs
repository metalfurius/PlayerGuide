// Create color class with immutable properties and static predefined colors, then create instances

Color x = new(222, 33, 44);
Color white = Color.White;

Console.WriteLine(x);
Console.WriteLine(white);

public class Color(int r, int g, int b)
{
    public int R { get; } = r;
    public int G { get; } = g;
    public int B { get; } = b;

    public override string ToString() => $"Color(R: {R}, G: {G}, B: {B})";

    public static Color Black => new(0, 0, 0);
    public static Color White => new(255, 255, 255);
    public static Color Red => new(255, 0, 0);
    public static Color Yellow => new(255, 255, 0);
    public static Color Cyan => new(0, 255, 255);
    public static Color Magenta => new(255, 0, 255);
    public static Color Green => new(0, 255, 0);
    public static Color Blue => new(0, 0, 255);

}