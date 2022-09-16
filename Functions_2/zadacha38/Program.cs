// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//массив из вещественных чисел
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

void printArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int maxValue(int[] arr)
{
    int maxValue = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= maxValue)
        {
            maxValue = arr[i];
        }
    }
    return maxValue;
}

int minValue(int[] arr)
{
    int minValue = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <= minValue)
        {
            minValue = arr[i];
        }
    }
    return minValue;
}

int[] myArray = new int[10];
FillArray(myArray);
printArray(myArray);
Console.WriteLine();
Console.WriteLine($"{maxValue(myArray)} - {minValue(myArray)} = {maxValue(myArray) - minValue(myArray)}");