// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string massege) // функция на ввод числа с консоли
{
    System.Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNaturalNumber(int a, int b)
{
    if (a > b) (a, b) = (b, a);
    if (a == b) return a;
    else return a + SumNaturalNumber(a + 1, b);
}

int m = Prompt("m -> ");
int n = Prompt("n -> ");
System.Console.WriteLine(SumNaturalNumber(m, n));
