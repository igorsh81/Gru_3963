// Задача №3
// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.

// Запрашиваем число

Console.WriteLine("Введите число : ");

// Считываем данные с консоли

string? linDay = Console.ReadLine();

// Проверяем , чтобы данные были не пустыми

if(linDay != null)

{
    // Парсим введенное число

    int day =int.Parse(linDay);

    // Создаем массив

    string[] dayWeek = new string[7];
    dayWeek[0] = "Понедельник";
    dayWeek[1] = "Вторник";
    dayWeek[2] = "Среда";
    dayWeek[3] = "Четверг";
    dayWeek[4] = "Пятница";
    dayWeek[5] = "Суббота";
    dayWeek[6] = "Воскресенье";

    // Выводим результат
    
    Console.WriteLine(dayWeek[day -1]);
}
