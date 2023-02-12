// Задача №1
// Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число
// квадратом второго.

// Запрашиваем первое число

Console.Write("Введите первое число: ");

// Считываем данные с консоли

string? numLine1 = Console.ReadLine();

Console.Write("Введите второе число: ");
string? numLine2 = Console.ReadLine();

// Проверяем , чтобы данные были не пустыми

if(numLine1!= null && numLine2!= null)
{
    // Парсим введенное число

   int num1 = int.Parse(numLine1);
   int num2 = int.Parse(numLine2);

   // Определяем является ли первое число квадратом второго

   if(num1 == num2 * num2)
   {
    // Да
    Console.WriteLine("Квадрат числа");
   }
    // Нет
   else
   {
    Console.WriteLine("Не является квадратом числа");
   }
 }
