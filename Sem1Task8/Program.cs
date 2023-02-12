// Задача №8


// Запрашиваем число 

Console.WriteLine("Введите число : ");

// Преобразуем переменную 

int num = Convert.ToInt32(Console.ReadLine());

// Назначаем переменную
int index = 1;

// Выполняем условие и выводим результат

while(index <= num)

    if(index % 2 ==0)
 {Console.Write(index + "  ");
       index++;
 }
else
{
     index++;
}
