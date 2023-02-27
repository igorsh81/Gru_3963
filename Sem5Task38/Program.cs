// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// Запрашиваем размер массива,назначаем переменные,конвертируем

int Size;

do
{
    Console.Write("Введите размер массива :  ");
    Size = Convert.ToInt32(Console.ReadLine());
}
while (Size <= 0);

int[] array = new int[Size];

// Создаем и выводим массив

int PrintArray(int[] intArray)
{
    Console.Write("[");
    for (int i = 0; i < intArray.Length; i++)
        if (i < Size - 1)
        {
            Console.Write(array[i] + " , ");
        }
        else
        {
            Console.Write(array[i]);
        }
    Console.WriteLine("]");    
    return 1;
}

int CreatArray(int[] intArray)
{
    for (int i = 0; i < intArray.Length; i++)
        array[i] = new Random().Next(1, 101);
    return 1;
}

// Выполняем условия

int MaxArray(int[] intArray)
{
    int MaxArray=array[0];
    for (int i = 1; i < intArray.Length; i++)
        {
            if (MaxArray<array[i])
            {
                MaxArray=array[i];
            }

        } 
    return MaxArray;
}

int MinArray(int[] intArray)
{
    int MinArray=array[0];
    for (int i = 1; i < intArray.Length; i++)
        {
            if (MinArray>array[i])
            {
                MinArray=array[i];
            }

        } 
    return MinArray;
}

// Выводим результат

CreatArray(array);

PrintArray(array);

Console.WriteLine($"Разницу между максимальным и минимальным элементов массива : {MaxArray(array)-MinArray(array)}");  