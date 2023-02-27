// Задача 36
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// Запрашиваем размер массива,назначаем переменные,конвертируем

int Size;
do
{
    Console.Write("Введите размер массива:  ");
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
        array[i] = new Random().Next(100, 1000);
    return 1;
}

// Выполняем условия

int Summa(int[] intArray)
{
    int summa=0;
    for (int i = 1; i < intArray.Length; i+=2)
        {
            summa+=array[i];
        } 
    return summa;
}

// Выводим результат

CreatArray(array);

PrintArray(array);

Console.WriteLine($"Сумму элементов, стоящих на нечётных позициях : {Summa(array)}");  