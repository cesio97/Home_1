// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
Console.WriteLine(" Ввести первое число: ");
int a = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine(" Ввести второе число: ");
int b = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine(" Ввести третье число: ");
int c = Convert.ToInt32 (Console.ReadLine ());
int max = a;

if (b > max) max = b;

if (c > max) max = c;
Console.WriteLine ("Maximum = " + max);