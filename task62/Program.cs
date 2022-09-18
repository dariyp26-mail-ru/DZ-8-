/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
Console.Clear();

string[,] FillArray() // Создание массива
{
  string[,] array = new string[4, 4];
  int temp = 1;
  int i = 0;
  int j = 0;
  while (temp <= array.GetLength(0) * array.GetLength(1))
  {
    if (temp < 10)
    {
      array[i, j] = "0" + temp.ToString();
    }
    else
    {
      array[i, j] = temp.ToString();
    }
    temp++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
      j++;
    else if (i < j && i + j >= array.GetLength(0) - 1)
      i++;
    else if (i >= j && i + j > array.GetLength(1) - 1)
      j--;
    else
      i--;
  }
  return array;
}

void PrintArray(string[,] matr) // Вывод на печать
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

string[,] array = FillArray(); // Создание массива
PrintArray(array); // Печать массива