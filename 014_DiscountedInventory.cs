// Switch expression to get the price of an item based on user input, with a special discount for a specific user

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");

Console.Write("What number do you want to see the price of? ");
int itemNumber = int.Parse(Console.ReadLine());

Console.Write("What is your name? ");
string userName = Console.ReadLine();

int result = itemNumber switch
{
    1 => 10,
    2 => 15,
    3 => 25,
    4 => 1,
    5 => 20,
    6 => 200,
    7 => 1,
    _ => -1,
};

if (result != -1 && userName == "Pako")
{
    Console.WriteLine($"{userName}, the price of the selected item is {result/2} gold.");
} 
else if (result != -1)
{
    Console.WriteLine($"{userName}, the price of the selected item is {result} gold.");   
}
else
{
    Console.WriteLine("Invalid item number.");
}