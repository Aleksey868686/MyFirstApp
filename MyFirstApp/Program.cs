// See https://aka.ms/new-console-template for more information

int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

int posNumQuantity = 0;

for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
{
    for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
    {
        if (arr[i, j] > 0)
        {
            posNumQuantity += 1;
        }
    }
}
Console.WriteLine($"Количество положительных чисел: {posNumQuantity}");
