int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArray(int countRows, int countColumn, int min, int max)
{
    int[,] arr = new int[countRows, countColumn];
    for (int i = 0; i < countRows; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}

void Print1DArray(int[] array)
{
    Console.Write("[");
    for (int j = 0; j < array.Length - 1; j++)
    {
        Console.Write($"{array[j]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

int[] BuildFreqDic(int[,] arr, int length)
{
    int[] dictionary = new int[length];
    for (int i =0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j< arr.GetLength(1); j++)
        {
            dictionary[arr[i,j]]++;
        }
    }
    return dictionary;
}

int inRow = ReadData("Please enter the desired number of rows: ");
int inCol = ReadData("Please enter the desired number of columns: ");
int[,] testArr = Gen2DArray(inRow, inCol, 1, 9);
Print2DArr(testArr);
Console.WriteLine();

int[] freqDic = BuildFreqDic(testArr, 10);
Print1DArray(freqDic);