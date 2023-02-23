// Задача №22
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

// Метод читает данные от пользывателя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine()??"0");
}

// Метод выводит данные пользователя
string LineBuilder(int end, int pow)
{
    string res = String.Empty;
    for(int i = 1; i <= end; i++)
    {
        res = res + Math.Pow(i,pow)+"\t";
    }
    return res;
}    

int N = ReadData("Введите конечное число :  ");
Console.WriteLine(LineBuilder(N,1));
Console.WriteLine(LineBuilder(N,3));