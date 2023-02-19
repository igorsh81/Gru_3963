// Задача №23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

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
        res = res + Math.Pow(i,3)+"\t";
        Console.Write(i+"\t");
    }
    return res;
}    

int N = ReadData("Введите конечное число :  ");
Console.WriteLine(LineBuilder(N,2));