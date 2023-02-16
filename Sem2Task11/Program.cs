// Задача №11
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
  
Random rnd = new Random();

  int rndNum = rnd.Next(100, 1000);
  Console.WriteLine($"Рандомное цисло = {rndNum}");

  int lastDigital = rndNum % 10;
  int firstDigital = rndNum / 100;
  rndNum = firstDigital * 10 + lastDigital;
  Console.WriteLine($"Число = {rndNum}");