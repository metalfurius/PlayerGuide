Coordinate x = new Coordinate(2, 3);
Coordinate y = new Coordinate(2, 4);
Coordinate z = new Coordinate(6, 4);

Console.WriteLine(Coordinate.Adjacent(x, y)); // True
Console.WriteLine(Coordinate.Adjacent(x, z)); // False
public struct Coordinate
{
    public int Row { get; }
    public int Column { get; }
    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }
    public static bool Adjacent(Coordinate a, Coordinate b)
    {
        int rowDiff = Math.Abs(a.Row - b.Row);
        int colDiff = Math.Abs(a.Column - b.Column);
        return (rowDiff == 1 && colDiff == 0) || (rowDiff == 0 && colDiff == 1);
    }
}