// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число промежутка: ");
int from = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число промежутка: ");
int to = Convert.ToInt32(Console.ReadLine());

printNaturalNumbers(from, to, 0);


void printNaturalNumbers(int numberStart, int numberStop, int sum) 
{

    if (numberStart > numberStop) 
    {
        Console.WriteLine($"Сумма элементов заданного промежутка = {sum}"); 
        return;
    }
    sum += (numberStart ++);
    printNaturalNumbers(numberStart, numberStop, sum);
}