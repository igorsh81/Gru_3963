﻿// Задача №15 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// Запрашиваем цифру

Console.WriteLine("Введите цифру обозначающую день недели :  ");

// Преобразуем,парсим,проверяем на null

int num = int.Parse(Console.ReadLine()??"0");

// Выполняем условие , выводим ответ

if (num==6 || num ==7)
{


Console.WriteLine ("Выходной");
}

else if (num<1 || num>7)

Console.WriteLine ("не является днем недели");


else 

Console.WriteLine ("Рабочий день");