// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int DigitalSum(int n)
{
    if(n == 0)
    {
        return 0;
    }
    return n % 10 + DigitalSum(n / 10);
}

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DigitalSum(n));