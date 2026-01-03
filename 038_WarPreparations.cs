Sword sword = new Sword(SwordMaterial.Iron, Gemstone.None, 85.0f, 12.5f);
Sword sword1 = sword with { Gemstone = Gemstone.Diamond };
Sword sword2 = sword1 with { Material = SwordMaterial.Steel, Length = 90.0f };

Console.WriteLine(sword);
Console.WriteLine(sword1);
Console.WriteLine(sword2);
public enum SwordMaterial
{
    Wood,
    Bronze,
    Iron,
    Steel,
    Binarium
}
public enum Gemstone
{
    None,
    Emerald,
    Amber,
    Sapphire,
    Diamond,
    Bitstone
}
public record Sword(SwordMaterial Material, Gemstone Gemstone, float Length, float CrossguardWidth);