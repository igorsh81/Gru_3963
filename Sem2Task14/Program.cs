// Задача №14
// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и 23. 

int num = int.Parse(Console.ReadLine()??"0");
bool oper = (num % 23 == 0) && (num % 7 == 0);

if (oper)
Console.WriteLine("Кратно");

else
Console.WriteLine("Не кратно");