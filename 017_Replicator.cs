// Write a C# program that copies the elements of one integer array to another integer array and then displays both arrays

int[] array1 = new int[5];

for (int i = 0; i < array1.Length; i++)
{
    Console.Write($"Enter integer {i + 1} for Array: ");
    array1[i] = int.Parse(Console.ReadLine());
}

int[] array2 = new int[5];

for (int i = 0; i < array1.Length; i++)
{
    array2[i] = array1[i];
}

for (int i = 0; i < array1.Length; i++)
{
    Console.WriteLine($"Array1 Element {i + 1}: {array1[i]}");
    Console.WriteLine($"Array2 Element {i + 1}: {array2[i]}");
}