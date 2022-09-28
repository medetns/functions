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
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int powerofnumber = PowerofA(numA, numB);
Console.WriteLine(powerofnumber);
