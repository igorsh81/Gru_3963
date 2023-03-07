int[,] Gen2DArrayMod(int countRows, int countColumn)
{
    int[,] arr = new int[countRows, countColumn];

    for (int i = 0; i < countRows; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = i + j;
        }
    }

    return arr;
}

void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] testArr = Gen2DArrayMod(8, 9);
Print2DArr(testArr);

