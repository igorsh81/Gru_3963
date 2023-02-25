//Задача №29.
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//* Ввести с клавиатуры длину массива и диапазон значений элементов

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

//Метод создает массив
int[] Gen1DArr(int num, int begin, int end)
{
  Random rnd = new Random();
  int[] arr = new int[num];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(begin, end);
  }
  return arr;
}

//Метод выводит массив пользователю
void Print1DArr(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ", ");
  }
  Console.WriteLine(arr[arr.Length - 1] + "]");
}

//Считываем данные, введенные пользователем
int arrLen = ReadData("Введите длину массива:");
int lower = ReadData("Введите нижнюю границу диапазона значений:");
int upper = ReadData("Введите верхнюю границу диапазона значений:");

//обращаемся к массиву, генерирующему массив
int[] arr = Gen1DArr(arrLen, lower, upper);

//выводим массив пользователю
Print1DArr(arr);
