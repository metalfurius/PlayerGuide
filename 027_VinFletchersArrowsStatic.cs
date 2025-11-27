// Make client choose between predefined arrows and custom arrows

Console.WriteLine("Please choose what type of arrow you would like to create:");
Console.WriteLine("1 - Elite Arrow");
Console.WriteLine("2 - Beginner Arrow");
Console.WriteLine("3 - Marksman Arrow");
Console.WriteLine("4 - Custom Arrow");
string choice = Console.ReadLine();

Arrow arrow = choice switch
{
    "1" => new Arrow(Arrow.Head.Steel, Arrow.Fletching.Plastic, 95),
    "2" => new Arrow(Arrow.Head.Wood, Arrow.Fletching.GooseFeather, 75),
    "3" => new Arrow(Arrow.Head.Steel, Arrow.Fletching.GooseFeather, 65),
    "4" => GetArrow(),
    _ => throw new ArgumentException("Invalid choice")
};

Console.WriteLine($"Total cost of the arrow: {arrow.GetTotalCost()}");

Arrow GetArrow()
{
    Arrow.Head head = getHeadFromUser();
    Arrow.Fletching fletching = getFletchingFromUser();
    float shaftLength = getShaftLengthFromUser();
    return new Arrow(head, fletching, shaftLength);
}

Arrow.Head getHeadFromUser()
{
    Console.WriteLine("Choose arrow head (Steel, Wood, Obsidian): ");
    string input = Console.ReadLine();
    return input.ToLower() switch
    {
        "steel" => Arrow.Head.Steel,
        "wood" => Arrow.Head.Wood,
        "obsidian" => Arrow.Head.Obsidian,
        _ => throw new ArgumentException("Invalid head type")
    };
}

Arrow.Fletching getFletchingFromUser()
{
    Console.WriteLine("Choose fletching type (Plastic, TurkeyFeather, GooseFeather): ");
    string input = Console.ReadLine();
    return input.ToLower() switch
    {
        "plastic" => Arrow.Fletching.Plastic,
        "turkeyfeather" => Arrow.Fletching.TurkeyFeather,
        "goosefeather" => Arrow.Fletching.GooseFeather,
        _ => throw new ArgumentException("Invalid fletching type")
    };
}

float getShaftLengthFromUser()
{
    Console.WriteLine("Enter shaft length (inches, between 60 and 100): ");
    string input = Console.ReadLine();
    if (float.TryParse(input, out float length) && length >= 60 && length <= 100)
    {
        return length;
    }
    else
    {
        throw new ArgumentException("Invalid shaft length");
    }
}

internal class Arrow(Arrow.Head head, Arrow.Fletching fletching, float shaftLength)
{

    private Head _head = head;
    private Fletching _fletching = fletching;
    private float _shaftLength = shaftLength;

    private float GetHeadCost()
    {
        return _head switch
        {
            Head.Steel => 10.0f,
            Head.Wood => 3.0f,
            Head.Obsidian => 5.0f,
            _ => 0.0f
        };
    }

    private float GetFletchingCost()
    {
        return _fletching switch
        {
            Fletching.Plastic => 0.50f,
            Fletching.TurkeyFeather => 1.00f,
            Fletching.GooseFeather => 1.50f,
            _ => 0.0f
        };
    }

    private float GetShaftCost()
    {
        return _shaftLength * 0.05f;
    }

    public float GetTotalCost()
    {
        return GetHeadCost() + GetFletchingCost() + GetShaftCost();
    }

    public enum Head {Steel, Wood, Obsidian}
    public enum Fletching {Plastic, TurkeyFeather, GooseFeather}
}