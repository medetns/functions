// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] randomnums)
{
    for (int i = 0; i < randomnums.Length; i++)
    {
        randomnums[i] = new Random().Next(-9, 9);
    }
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
}

int countEven(int[] array)
{
    int count = 0;
    foreach (int value in array)
    {
        if (value % 2 == 0 && value != 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = new int[10];
FillArray(array);
printArray(array);
Console.WriteLine();
Console.WriteLine(countEven(array));
