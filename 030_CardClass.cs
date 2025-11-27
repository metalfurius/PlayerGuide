// Create Card class with Color and Rank enums, and IsFaceCard property, then create instances and print all combinations

List<Color> colors = new List<Color>
{
    Color.Red,
    Color.Green,
    Color.Blue,
    Color.Yellow
};
List<Rank> ranks = new List<Rank>
{
    Rank.One,
    Rank.Two,
    Rank.Three,
    Rank.Four,
    Rank.Five,
    Rank.Six,
    Rank.Seven,
    Rank.Eight,
    Rank.Nine,
    Rank.Ten,
    Rank.Dollar,
    Rank.Percent,
    Rank.Caret,
    Rank.Ampersand
};

foreach (var color in colors)
{
    foreach (var rank in ranks)
    {
        Card card = new(color, rank);
        Console.WriteLine($"{card.Color} {card.Rank} - IsFaceCard: {card.IsFaceCard}");
    }
}


public class Card (Color color, Rank rank)
{
    public Color Color = color;
    public Rank Rank = rank;

    public bool IsFaceCard => Rank == Rank.Dollar || Rank == Rank.Percent || Rank == Rank.Caret || Rank == Rank.Ampersand;
}
public enum Color { Red, Green, Blue, Yellow }
public enum Rank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Percent, Caret, Ampersand }