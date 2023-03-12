// Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// Запрашиваем переменные

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
int temp = m;

// Назначаем переменные

if (m > n) 
{
  m = n; 
  n = temp;
}
PrintSumm(m, n, temp=0);

// Выполняем условие , выводим результат

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов = {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}

