Console.WriteLine("How many chocolate eggs where gathered today?");
string eggsInput = Console.ReadLine();
int eggs = int.Parse(eggsInput);

int forSisters = eggs / 4;
int forDuckbear = eggs % 4;

Console.WriteLine("Each sister gets: " + forSisters + " eggs");
Console.WriteLine("Duckbear gets: " + forDuckbear + " eggs");