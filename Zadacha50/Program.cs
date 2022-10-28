//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//[1,7] -> такого элемента в массиве нет

Console.WriteLine("Введите позиции элемента: ");

int lineI = Convert.ToInt32(Console.ReadLine());
int columnJ = Convert.ToInt32(Console.ReadLine());

int[,] array = new Int32[5, 5];

randomFilling(array, -10, 10);
arrayOutput(array);
foundElement(array, lineI, columnJ);

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

void foundElement(int[,] arr, int lineI, int columnJ)
{
    if (lineI > arr.GetLength(0) - 1 || columnJ > arr.GetLength(1) - 1)
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        Console.WriteLine($"Элемент, который искали {arr[lineI, columnJ]}");
    }
}

void arrayOutput(int[,] arr)
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