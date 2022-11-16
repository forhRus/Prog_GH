// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
int Prompt(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

(double x, double y) FindCoord(double b1, double k1, double b2, double k2)
{
    //1) k1x + b1 = k2x + b2; 2) k1x = k2x + (b2 - b1); 3) k1x - k2x = (b2 - b1); 4) (k1 - k2) = (b2 - b1) / x; 5) x = (b2 - b1) / (k1 - k2);
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}

double b1 = Prompt("Введите b1 -> ");
double k1 = Prompt("Введите k1 -> ");
double b2 = Prompt("Введите b2 -> ");
double k2 = Prompt("Введите k2 -> ");
(double x, double y) = FindCoord(b1, k1, b2, k2);
System.Console.WriteLine($"Точка пересечения прямых ({x}, {y}).");