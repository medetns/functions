// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int AckermannFunc(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermannFunc(m - 1, 1);
    return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
}

Console.WriteLine(AckermannFunc(firstNumber, secondNumber));
