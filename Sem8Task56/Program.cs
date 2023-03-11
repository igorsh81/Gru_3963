// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Создаем массив

void CreateRandomArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
}

void ShowArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumLine(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

// Выполняем условие

void FindingMinimumAmount(int[,] array)
{
    int rowMinSum = 0;
    int minSum = SumLine(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumLine = SumLine(array, i);
        if (minSum > tempSumLine)
        {
            minSum = tempSumLine;
            rowMinSum = i;
        }
    }
// Выводим результат

    Console.WriteLine($"\nНаименьшая сумма элементов {minSum}, в строке {rowMinSum + 1}");
}

const int numberOfLines = 4;
const int numberOfColumns = 5;
int[,] array = new int[numberOfLines, numberOfColumns];

CreateRandomArray(array);
ShowArray(array);
FindingMinimumAmount(array);