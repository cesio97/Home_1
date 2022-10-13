// Напишите проограмму, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве


double LenSegment(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dx = x1 - x2;
    double dy = y1 - y2;
    double dz = z1 - z2;
    return Math.Sqrt(dx*dx + dy*dy + dz*dz);
    
}


Console.Write("Введите х координату 1 точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y координату 1 точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z координату 1 точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x координату 2 точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y координату 2 точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z координату 2 точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Длина отрезка ({x1},{y1},{z1}) ({x2},{y2},{z2}) равна {LenSegment(x1, y1, z1, x2, y2, z2)}");


