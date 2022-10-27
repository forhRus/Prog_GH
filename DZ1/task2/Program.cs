// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 -1 -> 44
// 0 9 9 -> 9

System.Console.Write("Введите первое число > ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число > ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число > ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max(int arg1, int arg2, int arg3)
{
    int i = arg1;
    if (i < arg2) i = arg2;
    if (i < arg3) i = arg3;
    return i;
}
Console.WriteLine($"самое большое число {max(num1, num2, num3)}.");