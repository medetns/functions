// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int NumberSumDigit(int num)
{
    int sum = 0;
    for (int i = 0; 0 < num; i++)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int number = int.Parse(Console.ReadLine());

Console.WriteLine(NumberSumDigit(number));