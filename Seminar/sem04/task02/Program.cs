// Задача 1: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int number = Prompt("Задайте число, и мы посчитаем сколько в нём цифр. -> ");

int Counter(int number)
{
    int count = 0;
    int num = number;
    while (num > 0 || num < 0)
    {
        num /= 10;
        count++;
        // if(num == 0) break;
    }
    return count;
}

System.Console.WriteLine($"в числе {number} - {Counter(number)} цифр.");
