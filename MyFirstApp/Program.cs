// See https://aka.ms/new-console-template for more information

var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
int buffer;

for (int i = 0; i < arr.Length; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] > arr[j])
        {
            buffer = arr[i];
            arr[i] = arr[j];
            arr[j] = buffer;
        }
    }
}

foreach (int i in arr)
{
    Console.Write(i);
}







