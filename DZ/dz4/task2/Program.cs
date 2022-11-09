// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int number = Prompt("Задайте число, чтобы получить сумму его цифр. -> ");

int SumDig(int number)
{
    int sum = 0;
    int num = number;
    if (num < 0) num = -num;
    while (num != 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}

System.Console.WriteLine($"сумма цифр в числе {number} = {SumDig(number)}");