//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int n)
{   
    int i = 1;
    while (i <= n)
    {
        Console.WriteLine($"куб числа {i} = {Math.Pow(i,3)}");
        i++;
    }
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Cube(number);
