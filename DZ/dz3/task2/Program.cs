// Задача 2: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

(int x, int y, int z) GetCoord(string massege) // функция для ввода кординат х, у, z какой-то "massege" точки
{
    System.Console.Write($"Введите координату х для точки {massege} > ");
    int x = Convert.ToInt32(Console.ReadLine());
    System.Console.Write($"Введите координату y для точки {massege} > ");
    int y = Convert.ToInt32(Console.ReadLine());
    System.Console.Write($"Введите координату z для точки {massege} > ");
    int z = Convert.ToInt32(Console.ReadLine());
    return (x, y, z);
}
// задали координаты для точек а и б.
(int xa, int ya, int za) = GetCoord("a");
(int xb, int yb, int zb) = GetCoord("b");

double Length(int x1, int y1, int z1, int x2, int y2, int z2) //функция считающая растояние между точками в трёхмерном пространстве. 
{
    int x = x1 - x2;
    int y = y1 - y2;
    int z = z1 - z2;
    double length = Math.Sqrt((x * x) + (y * y) + (z * z));
    return length;
}
System.Console.WriteLine($"Расстояние между точками {Length(xa, ya, za, xb, yb, zb):f2}.");
