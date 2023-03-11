// Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.

// Запрашиваем размер матрицы,назначаем переменные,
// заполняем массив
Console.WriteLine("Введите количество строк и столбцов");
int length = int.Parse(Console.ReadLine()??"0");
int[,] array = new int[length, length];
int number = 1;
int i = 0;
int j = 0;
while (number <= length * length)
{
    array[i, j] = number;
    if (i <= j + 1 && i + j < length - 1)
        j++;
    else if (i < j && i + j >= length - 1)
        i++;
    else if (i >= j && i + j > length - 1)
        j--;
    else
        i--;
    number++;
}
// Выводим результат

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
PrintArray(array);
