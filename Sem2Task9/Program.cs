
System.Random numSintezator = new System.Random();

// // Вариант 1

int rndNumbers = numSintezator.Next(10,100);
Console.WriteLine(rndNumbers);
int firstNum = rndNumbers / 10;
int sekondNum = rndNumbers % 10;

if(firstNum > sekondNum)
{
    Console.WriteLine("Первое число больше  " + firstNum + "  второго  " + sekondNum);
}
else
{
    Console.WriteLine(sekondNum);
}

// Вариант 2

char [] digits = numSintezator.Next(10 ,100).ToString().ToArray();
Console.WriteLine(digits);
int firstNumber = ((int)digits[0])-48;
int secondNumber = ((int)digits[1])-48;

int resultNumber = (firstNumber>secondNumber)?resultNumber=firstNumber = firstNumber:resultNumber=secondNumber;
Console.WriteLine(resultNumber);