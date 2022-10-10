// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа


int n = 0;

Console.WriteLine("Введите трехзначное число: ");
n = Convert.ToInt32(Console.ReadLine());
if (n >= 100 && n <= 999)
{
    int d = n / 10;
    int Secondnumber = d % 10;
    Console.WriteLine("Bторая цифра числа =" + Secondnumber);
}
else
{
    Console.WriteLine("Это не трехзначное число");
}




