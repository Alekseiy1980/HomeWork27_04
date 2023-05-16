void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
    }
    Console.WriteLine();
}

void SortArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[minPosition] < arr[j]) minPosition = j;

        }
        int tmp = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = tmp;
    }

}
int[] arr = { 1, 6, 8, 3, 1, 6, 9, 0, 2 };
PrintArray(arr);
SortArray(arr);
Console.WriteLine();
PrintArray(arr);

