// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
n = Math.Abs(n);

if (n >= 100 )
{
    if (n > 999)
    {
        int i = 10;
        while (n / i > 1000)
        {i = i * 10;}
        Console.WriteLine("Третья цифра числа: " + (n / i) % 10);
    }
    else
    Console.WriteLine("Третья цифра числа: " + n % 10);
}


else 
{
    Console.WriteLine("Третьей цифры в числе нет");
}