// Задача 3: Напишите программу, которая принимает на вход координаты
//  двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

(int x, int y) GetCoord(string massege) // функция для ввода кординат х и у какой-то "massege" точки
{
    System.Console.Write($"Введите координату х для точки {massege} > ");
    int x = Convert.ToInt32(Console.ReadLine());
    System.Console.Write($"Введите координату y для точки {massege} > ");
    int y = Convert.ToInt32(Console.ReadLine());
    return (x, y);
}
// задали точки.
(int xa, int ya) = GetCoord("a");
(int xb, int yb) = GetCoord("b");

double Length(int x1, int y1, int x2, int y2) //функция считающая длину гипотинузы
{
    int ab = x1 - x2;
    int bc = y1 - y2;
    double ac = Math.Sqrt((ab * ab) + (bc * bc));
    return ac;
}
System.Console.WriteLine($"Расстояние между точками {Length(xa, ya, xb, yb)}.");

