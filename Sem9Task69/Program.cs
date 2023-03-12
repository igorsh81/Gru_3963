int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}
long RecPow(int a, int b)
{
    if (b <= 1)
    {
        return a;
    }
    else { return a * (RecPow(a, b - 1)); }
}
int a = ReadDataToInt("Enter the base : ");
int b = ReadDataToInt("Enter the power: ");
Console.WriteLine();
Console.WriteLine(RecPow(a, b));