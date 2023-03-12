// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n

// Запрашиваем числа , парсим

Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите начальное число N:");
int numberN = int.Parse(Console.ReadLine()??"0");

///Метод вычисления функции Аккермана
int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
return AckermannFunction(numberM, numberN);
}

// Выводим результат

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");