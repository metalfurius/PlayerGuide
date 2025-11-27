// Get target row and column from user and print adjacent deployment coordinates
Console.WriteLine("Target Row?");
string rowInput = Console.ReadLine();
int row = int.Parse(rowInput);

Console.WriteLine("Target Column?");
string columnInput = Console.ReadLine();
int column = int.Parse(columnInput);

Console.WriteLine("Deploy at " + row + ", " + (column - 1));
Console.WriteLine("Deploy at " + (row - 1) + ", " + column);
Console.WriteLine("Deploy at " + row + ", " + (column + 1));
Console.WriteLine("Deploy at " + (row + 1) + ", " + column);