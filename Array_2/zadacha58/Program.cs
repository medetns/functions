// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк 1-го массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов 1-го массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = FillArray(m, n, 0, 10);
Console.WriteLine("Первая матрица");
PrintArray(firstMatrix);

Console.Write("Введите количество строк 2-го массива: ");
int p = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов 2-го массива: ");
int q = Convert.ToInt32(Console.ReadLine());

int[,] secondMatrix = FillArray(p, q, 0, 10);
Console.WriteLine("Вторая матрица");
PrintArray(secondMatrix);

int[,] resultMatrix = new int[m,q];

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMatrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}