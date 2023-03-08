// Задача 52. 
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

//получения числа с консоли
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// Создание массива заданной размерности
int[,] InitMatrix(int m, int n)
{
    int[,] resultMatrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix[i, j] = rnd.Next(10, 99);
        }
    }

    return resultMatrix;
}

// Вывод массива на экран
void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Нахождение среднего арифметического каждого столбца
void GetSrednee(int[,] matrix, int m, int n)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    double[] srednee = new double[n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            srednee[i] = srednee[i] + matrix[j, i];
        }
        srednee[i] = srednee[i] / m;
        Console.Write("{0,6:F1};", srednee[i]);
    }
}

int m = ReadData("Введите число строк : ");
int n = ReadData("Введите число столбцов :");
int[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);
GetSrednee(matrix, m, n);