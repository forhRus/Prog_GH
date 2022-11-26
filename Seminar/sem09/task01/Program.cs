//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int Prompt(string massege) // функция на ввод числа с консоли
{
    System.Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());

}
void PrintNumber(int n)
{
    if (n <= 0)
    {
        return;
    }
    // System.Console.WriteLine(n);
    PrintNumber(n - 1);
    System.Console.WriteLine(n);

}

int number = Prompt("Задайте число -> ");
PrintNumber(number);
