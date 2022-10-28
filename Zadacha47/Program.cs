// Задача 47. 
//Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9   



Console.WriteLine("Введите размерность массива: "); 
int m = Convert.ToInt32(Console.ReadLine()); 
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину интервалов: "); 
int numbersInterval = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

void FillArray(double[,] array, int numbersInterval)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-numbersInterval, numbersInterval) + (new Random().Next(0, 9)) * 0.1;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();

    }
    Console.WriteLine();
}
FillArray(array, numbersInterval);
PrintArray(array);
