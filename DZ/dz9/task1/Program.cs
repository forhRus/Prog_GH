//  Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string massege) // функция на ввод числа с консоли
{
    System.Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintEvenNumbers(int a, int b)
{
    if (a > b)
    {
        System.Console.WriteLine();
        return;
    }
    if (a % 2 != 0)
    {
        a++;
    }

    System.Console.Write(a + " ");
    PrintEvenNumbers(a + 2, b);
}

int m = Prompt("m -> ");
int n = Prompt("n -> ");
PrintEvenNumbers(m, n);
