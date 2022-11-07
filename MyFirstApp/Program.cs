// See https://aka.ms/new-console-template for more information

int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

int buffer = 0;

for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
{
    for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
    {
        for (int f = j + 1; f < arr.GetLength(1); f++)
        {
            if (arr[i, j] > arr[i, f])
            {
                buffer = arr[i, j];
                arr[i, j] = arr[i, f];
                arr[i, f] = buffer;
            }
        }
    }
}

for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
{
    for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
    {
        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}
