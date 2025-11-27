// Calculate the area of a triangle given width and height from user input
Console.WriteLine("What is the triangle width?");
string widthInput = Console.ReadLine();
int width = int.Parse(widthInput);

Console.WriteLine("What is the triangle height?");
string heightInput = Console.ReadLine();
int height = int.Parse(heightInput);

int area = (width * height) / 2;
Console.WriteLine("The triangle area is: " + area);