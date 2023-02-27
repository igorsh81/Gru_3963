// Задача №33
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.


int[] Gen1DArray(int len, int min, int max)
{
    // Блок корректировки входных данных 
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}
void Print1DArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.WriteLine("]");
}

int SearchElem(int[] arr, int elem)
{
    int result = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elem)
        {
            result = i; break;
        }
    }
    return result;
}
int[] testArr = Gen1DArray(12, -9, 9);
Print1DArray(testArr);
Console.Write("Введите искомый элемент: ");
int elem = int.Parse(Console.ReadLine()??"0");
int res = SearchElem(testArr, elem);

if (res > 0)
{
    Console.WriteLine("Искомый эелемент находится в массиве с индексом: " + res);
}
else
{
    Console.WriteLine("Искомый эелемент в массиве отсутствует  ");
}

// int[] Gen1DArr(int len, int min, int max)
// {
//     // Корректировка входных данных
//     if (min > max)
//     {
//         int buf = min;
//         min = max;
//         max = buf;
//     }

//     Random rnd = new Random();
//     int[] arr = new int[len];

//     for (int i = 0; i < len; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }

//     return arr;
// }

// void Print1DArr(int[] arr)
// {
//     Console.Write("[");

//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write($"{arr[i]},\t");
//     }
//     Console.WriteLine($"{arr[arr.Length - 1]}]");
// }

// //Принимаем из консоли число
// int ReadInputInt(string mess)
// {
//     Console.Write(mess);
//     return Convert.ToInt32(Console.ReadLine() ?? "0");
// }

// //Метод для вывода данных
// void WriteMess(string mess)
// {
//     Console.WriteLine(mess);
// }

// bool SearchElem(int[] arr, int num)
// {
//     bool res = false;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == num) 
//         {
//             res = true;

//             break;
//         }
//     }
//     return res;
// }

// int[] mass = Gen1DArr(12, -9, 9);

// int searchNum = ReadInputInt("Введите число для поиска в массиве: ");
// Print1DArr(mass);

// WriteMess(SearchElem(mass, searchNum)? "Данное число найдено": "Данное число не найдено");