Pack pack = new Pack(5, 20.0f, 15.0f);
while (true)
{
    Console.WriteLine(pack.ToString());

    Console.WriteLine("Choose an item to add to your pack:");
    Console.WriteLine("1. Arrow");
    Console.WriteLine("2. Bow");
    Console.WriteLine("3. Rope");
    Console.WriteLine("4. Water");
    Console.WriteLine("5. Food");
    Console.WriteLine("6. Sword");
    Console.WriteLine("7. Exit");

    string choice = Console.ReadLine();
    InventoryItem itemToAdd = choice switch
    {
        "1" => new Arrow(),
        "2" => new Bow(),
        "3" => new Rope(),
        "4" => new Water(),
        "5" => new Food(),
        "6" => new Sword(),
        "7" => null,
        _ => null
    };

    if (itemToAdd != null)
    {
        if (pack.AddItem(itemToAdd))
        {
            Console.WriteLine($"{itemToAdd.GetType().Name} added to pack.");
        }
        else
        {
            Console.WriteLine($"Cannot add {itemToAdd.GetType().Name}. Pack limits exceeded.");
        }
    }
    else if (choice == "7")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid choice. Try again.");
    }
}
public class InventoryItem
{
    public float Weight { get; }
    public float Volume { get; }

    public InventoryItem(float weight, float volume)
    {
        Weight = weight;
        Volume = volume;
    }
}

public class Arrow : InventoryItem { 
    public Arrow() : base(0.1f, 0.05f) { }
    public override string ToString() => "Arrow";
}
public class Bow : InventoryItem { 
    public Bow() : base(1.0f, 4.0f) { } 
    public override string ToString() => "Bow";
}
public class Rope : InventoryItem { 
    public Rope() : base(1.0f, 1.5f) { } 
    public override string ToString() => "Rope";
}
public class Water : InventoryItem { 
    public Water() : base(2.0f, 3.0f) { }
    public override string ToString() => "Water";
}
public class Food : InventoryItem { 
    public Food() : base(1.0f, 0.5f) { }
    public override string ToString() => "Food";
}
public class Sword : InventoryItem { 
    public Sword() : base(5.0f, 3.0f) { }
    public override string ToString() => "Sword";
}

public class Pack (int maxItems, float maxWeight, float maxVolume)
{
    private List<InventoryItem> items = new List<InventoryItem>();
    private float currentWeight = 0;
    private float currentVolume = 0;

    public bool AddItem(InventoryItem item)
    {
        if (items.Count >= maxItems ||
            currentWeight + item.Weight > maxWeight ||
            currentVolume + item.Volume > maxVolume)
        {
            return false; // Cannot add item
        }

        items.Add(item);
        currentWeight += item.Weight;
        currentVolume += item.Volume;
        return true; // Item added successfully
    }

    public override string ToString()
    {
        if (items.Count == 0)
        {
            return "Pack is empty.";
        }
        return "Pack contains: " + string.Join(", ", items);
    }
}
