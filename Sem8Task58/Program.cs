// Задача 58: 
// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

// Создание матриц

(int[,], int[,]) InitTwoMatrices(int m, int n, int x, int y)
{
    int[,] firstResMtrx = new int[m, n];
    int[,] secondResMtrx = new int[x, y];
    Random rnd = new Random();
    
    for (int i = 0; i < firstResMtrx.GetLength(0); i++)
    {
        for (int j = 0; j < firstResMtrx.GetLength(1); j++)
        {
            firstResMtrx[i, j] = rnd.Next(1, 10);
        }
    }

    for (int i = 0; i < secondResMtrx.GetLength(0); i++)
    {
        for (int j = 0; j < secondResMtrx.GetLength(1); j++)
        {
            secondResMtrx[i, j] = rnd.Next(1, 10);
        }
    }
    return (firstResMtrx, secondResMtrx);
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}     ");
        }
        Console.WriteLine();   
    }
    Console.WriteLine();
}
// Сравнение матриц

int GetMatrSize(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] FindProdOfTwoMatrices(int[,] firstMatrix, int[,] secondMatrix)
{
    
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
    {
        Console.WriteLine("Матрицы несовместимы!"); 
    }
    
// Переменная для производной матрицы

    int[,] productMtrx = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)]; 

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            productMtrx[i, j] = 0;
            {
                for (int k = 0; k < firstMatrix.GetLength(1); k++)
                {
                    productMtrx[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                }
            }
        }
    }
    return productMtrx;
}

// Вывод результата

int rowsFirst = GetMatrSize("Введите количество строк 1 таблицы:");
int colsFirst = GetMatrSize("Введите количество столбцов 1 таблицы:");
int rowsSecond = GetMatrSize("Введите количество строк 2 таблицы:");
int colsSecond = GetMatrSize("Введите количество столбцов 2 таблицы:");
Console.WriteLine();
(int[,] firstMtrx, int[,] secondMtrx) = InitTwoMatrices(rowsFirst, colsFirst, rowsSecond, colsSecond);
Console.WriteLine ("Матрица 1:");
Console.WriteLine();
PrintMatrix(firstMtrx);
Console.WriteLine ("Матрица 2:");
Console.WriteLine();
PrintMatrix(secondMtrx);
int[,] resultMatrix = FindProdOfTwoMatrices(firstMtrx, secondMtrx);
Console.WriteLine("Произведение двух матриц  ");
PrintMatrix(resultMatrix);
