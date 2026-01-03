ColoredItem<Sword> blueSword = new ColoredItem<Sword>(new Sword(), "blue");
ColoredItem<Bow> redBow = new ColoredItem<Bow>(new Bow(), "red");
ColoredItem<Axe> greenAxe = new ColoredItem<Axe>(new Axe(), "green");

blueSword.Display();
redBow.Display();
greenAxe.Display();


public class ColoredItem<T>
{
    public T Item { get; set; }
    public string Color { get; set; }

    public ColoredItem(T item, string color)
    {
        Item = item;
        Color = color;
    }
    public void Display()
    {
        System.Console.WriteLine($"Item Type: {typeof(T).Name}, Color: {Color}");
    }
}

public class Sword { }
public class Bow { }
public class Axe { }