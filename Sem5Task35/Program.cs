// Задача №35
// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] Gen1DArr(int len, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }

    Random rnd = new Random();
    int[] arr = new int[len];

    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},\t");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

//Метод для вывода данных
void WriteMess(string mess)
{
    Console.WriteLine(mess);
}

int NumElemInRange(int[] arr, int min, int max)
{
    int res = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>min && arr[i]<max) res++;
    }

    return res;
}

int[] mass = Gen1DArr(123, -100, 100);
Print1DArr(mass);

WriteMess($"{NumElemInRange(mass, 10, 99)}");