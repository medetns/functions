// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.

int PowerofA(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}

Console.WriteLine("Введите A: ");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите B: ");
int numB = int.Parse(Console.ReadLine());

int powerofnumber = PowerofA(numA, numB);
Console.WriteLine(powerofnumber);
