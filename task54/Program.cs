/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] FillArray() // Создание массива
{
  int x = new Random().Next(2, 10);
  int y = new Random().Next(2, 10);
  int[,] array = new int[x, y];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0, 10);
    }
  }
  return array;
}

int[,] SortArray(int[,] matr) // Сортировка массива
{
  int temp = 0;
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int k = 0; k < matr.GetLength(1) - 1; k++)
    {
      for (int j = 0; j < matr.GetLength(1) - 1; j++)
      {
        if (matr[i, j] < matr[i, j + 1])
        {
          temp = matr[i, j];
          matr[i, j] = matr[i, j + 1];
          matr[i, j + 1] = temp;
        }
      }
    }
  }
  return matr;
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

int[,] array = FillArray(); // Создание массива
Console.WriteLine("Исходный массив:");
PrintArray(array); // Печать массива
Console.WriteLine();
Console.WriteLine("Упорядоченный массив:");
SortArray(array);
PrintArray(array); // Печать массива