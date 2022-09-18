/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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

void MinSummStroke(int[,] matr) // Поиск строки с мин суммой
{
  int[] array = new int[matr.GetLength(0)];
  int summ = 0;
  int min = 0;

  for (int k = 0; k < matr.GetLength(0); k++)
  {
    for (int i = 0; i < matr.GetLength(1); i++)
    {
      summ += matr[k, i];
    }
    array[k] = summ;
    summ = 0;
  }

  for (int l = 0; l < matr.GetLength(0) - 1; l++)
  {
    if (array[min] > array[l + 1]) min = l + 1;
  }
  Console.WriteLine("Cтрокa с наименьшей суммой элементов: " + (min + 1));
}

int[,] array = FillArray(); // Создание массива
PrintArray(array); // Печать массива
MinSummStroke(array);