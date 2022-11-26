// Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int Prompt(string massege) // функция на ввод числа с консоли
{
    System.Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int m, int n)
{
    if(m >= n)
    {
        return;
    }
   
    System.Console.WriteLine(m);
    PrintNumbers(m + 1, n);
}

int m = Prompt("m -> ");
int n = Prompt("n -> ");
PrintNumbers(m, n);