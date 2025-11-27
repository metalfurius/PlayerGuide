Console.WriteLine("How many provinces do you own?");
string provincesInput = Console.ReadLine();
int provinces = int.Parse(provincesInput);

Console.WriteLine("How many duchies do you own?");
string duchiesInput = Console.ReadLine();
int duchies = int.Parse(duchiesInput);

Console.WriteLine("How many estates do you own?");
string estatesInput = Console.ReadLine();
int estates = int.Parse(estatesInput);

int totalPoints = (provinces * 6) + (duchies * 3) + (estates * 1);
Console.WriteLine("Your total points are: " + totalPoints); 