// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.WriteLine("Введите цифру от 1 до 7");
int b = Convert.ToInt32(Console.ReadLine());
if (b == 6 | b == 7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Будний день");
}