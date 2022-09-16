// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] randomNums)
{
    for (int i = 0; i < randomNums.Length; i++)
    {
        randomNums[i] = new Random().Next(-9, 9);
    }
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
}

int sumOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] array = new int[10];
FillArray(array);
printArray(array);
Console.WriteLine();
Console.WriteLine(sumOdd(array));