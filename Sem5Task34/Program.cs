// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Запрашиваем размер массива,назначаем переменные,конвертируем

int Size;

do
{
    Console.Write("Введите размер массива :  ");
    Size = Convert.ToInt32(Console.ReadLine()??"0");
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
            Console.Write(array[i] + ", ");
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
        array[i] = new Random().Next(100, 1001);
    return 1;
}

// Выполняем условия

int EvenNumber(int[] intArray)
{
    int count=0;
    for (int i = 0; i < intArray.Length; i++)
        if (array[i]%2==0)
        {
            count++;
        } 
    return count;
}


// Выводим результат

CreatArray(array);

PrintArray(array);

Console.WriteLine($"Количество чётных чисел в массиве : {EvenNumber(array)}"); 

