// Задача №13 
// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает,что третьей цифры нет

// Запрашиваем число

Console.WriteLine("Введите число : ");

// Преобразуем число , делаем проверку на null

string num = (Console.ReadLine()??"0");

// Преобразуем в массив

char[] arr = num.ToCharArray(); 

// Выполняем условие

if (num.Length >= 3)

// Выводим результат

Console.WriteLine(arr[2]);
    else 
            Console.WriteLine("Третьей цифры нет");
    
