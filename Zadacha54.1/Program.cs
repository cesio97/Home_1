// Задайте двумерный массив. Напишите программу, которая упорядочит элементы по убыванию (или возрастанию).

// У меня на убывание элементов в строках и столбцах


Console.Write("Введи количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,n];

void FillArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = new Random().Next(1,10);;
    }
  }
}

void Print(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1)-1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

void OrderArrayColumn(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
          for (int g = 0; g < array.GetLength(0)-1; g++)
          {
             if (array[g, j] < array[g+1, j])
              {
                  int temp = array[g+1,j];
                  array[g+1,j] = array[g, j];
                  array[g, j] = temp;
              }
          }
      }
    }
}

Console.WriteLine($"Первоначальный массив: ");
FillArray(array);
Print(array);
Console.WriteLine($"Упорядоченный массив по строкам: ");
OrderArrayLines(array);
Print(array);
Console.WriteLine($"Упорядоченный массив по столбцам: ");
OrderArrayColumn(array);
Print(array);