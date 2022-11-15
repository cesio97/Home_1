// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//1 4 7 2    7 4 2 1 
// 5 9 2 3   9 5 3 2 
// 8 4 2 4   8 4 4 2


int[,] array = new Int32[3, 4];

randomFilling(array, 0, 10);
Console.WriteLine("Первоначальный массив: ");
Printarray(array);
sortLine(array);
Console.WriteLine("Преобразованный массив: ");
Printarray(array);

void randomFilling(int[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
}

void sortLine(int[,] arr)
{
    for (var i = 0; i < arr.GetLength(0); i++)
    {
                
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int f = 0; f < arr.GetLength(1); f++)
            {

                if (arr[i, j] > arr[i, f])
                 {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, f];
                    arr[i, f] = temp;
                 }
            } 
        }   
    }
}


void Printarray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }

        Console.WriteLine(" ");
    }
}
