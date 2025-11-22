// Find the minimum value and average of an integer array using foreach loops

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentMinimum = array[0];

foreach (int number in array)
{
    if (number < currentMinimum)
    {
        currentMinimum = number;
    }
}

Console.WriteLine($"The minimum value in the array is: {currentMinimum}");

int sum = 0;
foreach (int number in array)
{
    sum += number;
}

float average = (float)sum / array.Length;
Console.WriteLine($"The average value of the array is: {average}");