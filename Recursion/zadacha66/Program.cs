// Задача 64: Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int PrintNumbers(int start, int end)
{
    int sum = 0;
    if (start == end + 1) return sum;
    return (sum + start + PrintNumbers(start + 1, end));
}

Console.WriteLine(PrintNumbers(firstNumber, secondNumber));