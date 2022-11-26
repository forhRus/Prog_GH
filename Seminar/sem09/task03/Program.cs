// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int Prompt(string massege) // функция на ввод числа с консоли
{
    System.Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigits(int n)
{
    if (n <= 0)
    {
        return 0;
    }

    return n%10 + SumDigits(n / 10);

}

int number = Prompt("Число -> ");
System.Console.WriteLine(SumDigits(number));
