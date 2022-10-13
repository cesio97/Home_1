// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом



Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int len = num.Length;

if (len == 5)
{
    if (num[0] == num[4] &&  num[1] == num[3])
    {
        Console.WriteLine($" {num} - Палиндром");
    }
    else
    {
        Console.WriteLine($" {num} - Не палиндром");
    }
}
else
{
    Console.WriteLine($" Увы: {num} - не пятизначное");
}