// Determine the direction of an enemy based on X and Y coordinates relative to the watch tower
Console.WriteLine("X: ");
string xInput = Console.ReadLine();
int x = int.Parse(xInput);

Console.WriteLine("Y: ");
string yInput = Console.ReadLine();
int y = int.Parse(yInput);

if (x > 0 && y > 0)
{
    Console.WriteLine("Enemy is Northeast");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Enemy is Northwest");
}
else if (x < 0 && y == 0)
{
    Console.WriteLine("Enemy is West");
}
else if (x > 0 && y == 0)
{
    Console.WriteLine("Enemy is East");
}
else if (x == 0 && y > 0)
{
    Console.WriteLine("Enemy is North");
}
else if (x == 0 && y < 0)
{
    Console.WriteLine("Enemy is South");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Enemy is Southwest");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Enemy is Southeast");
}
else
{
    Console.WriteLine("Enemy is on the watch tower");
}