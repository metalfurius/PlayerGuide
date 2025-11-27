Console.WriteLine("What kind of thing are we talking about?");

/* Type of thing */
string thingType = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");

// Description of thing
string description = Console.ReadLine();

// "Doom" text
string doomText = "Doom"; // Modified to fix the "of of" bug.

/* Number */
string number = "3000";

Console.WriteLine("The " + description + " " + thingType + " of " + doomText + " " + number + "!");