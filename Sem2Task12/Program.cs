// Задача №12
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если второе число некратно первому, то программа выводит остаток от деления.

int firstNum = int.Parse(Console.ReadLine()??"0");
int secondNum = int.Parse(Console.ReadLine()??"0");
int rem = firstNum % secondNum;
if (rem ==0)
Console.WriteLine("Кратно");

else
Console.WriteLine("Не кратно  "+ rem  + "  остаток");