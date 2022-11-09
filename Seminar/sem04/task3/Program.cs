// Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Prompt(string massege)
{
    System.Console.Write(massege);
    return int.Parse(Console.ReadLine());
}

int number = Prompt("Введите число -> ");

int Multi(int number)
{
    int multi = 1;
    int num = number;
    while(num > 0 || num < 0)
    {
        multi = num%10 * multi;
        num /=10;
    }
    return multi;
}

System.Console.WriteLine($"произведение всех цифр в числе {number} = {Multi(number)}");
