/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] FillArray(int x) // Создание массива
{
  int[,] array = new int[x, x];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0, 10);
    }
  }
  return array;
}

int[,] MultArray(int[,] arrayA, int[,] arrayB) // Умножение матриц
{
  int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
  for (int i = 0; i < arrayC.GetLength(0); i++)
  {
    for (int j = 0; j < arrayB.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < arrayA.GetLength(1); k++)
      {
        sum += arrayA[i, k] * arrayB[k, j];
      }
      arrayC[i, j] = sum;
    }
  }
  return arrayC;
}

void PrintArray(int[,] matr) // Вывод на печать
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
  }
}

int x = new Random().Next(2, 6); //Размер матрицы

int[,] arrayA = FillArray(x);
int[,] arrayB = FillArray(x);
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
int[,] arrayC = MultArray(arrayA, arrayB);
PrintArray(arrayC);