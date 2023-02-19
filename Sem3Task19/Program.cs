// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// Запрашиваем число и преобразуем,проверяем на null
Console.WriteLine ("Введите 5-ти значное число: ");
string number = (Console.ReadLine()??"0");
int len = number.Length;

// Выполняем условия, выводим результат
if (len == 5)
{
    if (number[0] == number[4] && number [1] == number[3])
    {
        Console.WriteLine(number + " Палиндром");
    }

    else
    {
        Console.WriteLine(number + " Не палиндром");
    }
}
else
{
    Console.WriteLine ("Вы ввели НЕ 5-и значное число");
}