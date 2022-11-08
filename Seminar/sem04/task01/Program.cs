// Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int number = Prompt("Задайте число, чтобы получить сумму его чисел. -> ");

bool Validate(int number)
{
    if (number <= 0)
    {
        System.Console.WriteLine("Введённое число должно быть положительным.");
        return false;
    }
    return true;
}

int SumGaus(int number)
{
    return (int)((number + 1) * (number / 2.0));
}

if (Validate(number))
{
    int sum = 0;
    int sumGaus = SumGaus(number);
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    System.Console.WriteLine($"Сумма чисел от 0 до {number} = {sum}, а по Гаусу {sumGaus}.");
}


