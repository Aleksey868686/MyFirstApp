// See https://aka.ms/new-console-template for more information

var array = new sbyte[] { 1, 2, 3, -1, 5, -20, -3, 6 };

int posNumQuantity = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        posNumQuantity += 1;
    }
}
Console.WriteLine($"Количество положительных чисел: {posNumQuantity}");