//Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2х2х2

Console.Write("Введи n: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи m: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи l: ");
int l = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[m, n, l];

FillArray(array);
Print(array);

void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int num = new Random().Next(10, 100);
                if(num != array[i, j, k])
                {
                array[i, j, k] = num;
                } 
            }
        }
    }
}

void Print (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write( $"{array[i,j,k]}({i},{j},{k}); ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
