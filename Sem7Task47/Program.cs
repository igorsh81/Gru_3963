// Задача 47. 
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

double [,] CreateArray(int lenRows, int lenColumns)
{
    // генерация строк
        double [,] array = new double[lenRows, lenColumns];
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++) 
        {
            // генерация столбцов
                for (int j = 0; j < array.GetLength(1); j++) 
                {
                    // задали вывод случайных, вещественных элементов массива, ограничили диапазон
                        array[i, j] = random.Next(10, 100)+ random.NextDouble();
                        
                }
        }
        // вернули двумерный массив
        return array; 
        
        
}
// вывод на экран
void PrintArray(double[,] array) 

// переход на следующую строку
{
        for (int i = 0; i < array.GetLength(0); i++)
        {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                        Console.Write($"{array[i, j]:f2}\t");
                }
                System.Console.WriteLine(); 
                
                
        }
}
// задали размер двумерного массива
double[,] array = CreateArray(3, 4);
 
// вывели масив на экран
PrintArray(array); 
