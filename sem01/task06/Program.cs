// Напишите программу, которая на вход принимает значение, а  на выходе показывает обратное значение.
// 1 -> 1 
// 2 -> 0.5
// 0.25 -> 4
System.Console.Write("Please type the number ");
double num = Convert.ToDouble(Console.ReadLine());

double funV(double arg)
{
    double i = 1 / arg;
    return i;
} 
Console.WriteLine($"Обратное число от {num} является {funV(num):f2}.");