// Задача 64: 
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// Выполнить с помощью рекурсии.

// Метод рекрусии

void OutputNumbers(int m, int n)
{
    if (m <= n)
    {
        OutputNumbers(m + 1, n);
        Console.Write($"{m} ");
    }
}

// Запрашиваем число,конвертируем,парсим и выводим результат

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()??"0");
int m = 1;
OutputNumbers(m, n);
