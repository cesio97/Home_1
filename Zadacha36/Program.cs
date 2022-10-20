// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях


Console.WriteLine("Введите длину массива:  ");
int len = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[len];

FillArrayRandomNumbers(numbers);
Console.WriteLine("Мой массив: ");
PrintArray(numbers);

int sum = 0;    

for (int n = 0; n < numbers.Length; n = n+2) 
    sum = sum + numbers[n];

    Console.WriteLine($"Cумма элементов, cтоящих на нечётных позициях = {sum}");


void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        { 
        numbers[i] = new Random().Next(1,10);
        }
}

void PrintArray(int[] numbers)      
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}


