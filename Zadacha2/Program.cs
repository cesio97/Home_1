// Напишите программу, которая на вход принимает два чила и выдает, какое число большее, а какое меньшее
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32 (Console.ReadLine ());
if (a>b)
{
     Console.WriteLine ("{0} наибольшее число", a);    
}
else 
{
    Console.WriteLine ("{0} наибольшее число", b);
}
Console.ReadLine ();
