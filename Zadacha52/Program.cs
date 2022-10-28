// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.WriteLine("Введите размерность массива: ");
int column = Convert.ToInt32(Console.ReadLine());
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину интервалов: ");
int numbersInterval = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[line, column];

void FillArray(int[,] array, int numbersInterval)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-numbersInterval, numbersInterval);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");

        }
        Console.WriteLine();

    }
    Console.WriteLine();
}

double average = 0;

void PrintAverage(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        average = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            average = average + array[j, i];
        }
        if (i < (array.GetLength(1) - 1))
        {
            Console.Write($"{(average / array.GetLength(1))}; ");
        }
        else Console.Write($"{(average / array.GetLength(1))} ");
    }

}

FillArray(array, numbersInterval);

Console.WriteLine("Массив: ");
PrintArray(array);

Console.WriteLine("Cреднее арифметическое каждого столбца: ");
PrintAverage(array);
