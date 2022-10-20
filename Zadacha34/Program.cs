//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива:  ");

int len = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[len];

FillArrayRandomNumbers(numbers);  
Console.WriteLine(" Мой массив будет такой: ");
PrintArray(numbers);

int count = 0;

for (int n = 0; n < numbers.Length; n++)
if (numbers[n] % 2 == 0)
count++;

Console.WriteLine($" Количество четных чисел в массиве - {count}");


void FillArrayRandomNumbers(int[] numbers)       // Заполнение
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);  // из условия - трехзначные
    }
}

void PrintArray(int[] numbers)                   // вывод массива на экран
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}