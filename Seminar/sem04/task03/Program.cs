// Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Prompt(string massege)
{
    System.Console.Write(massege);
    return int.Parse(Console.ReadLine());
}

int number = Prompt("Введите число -> ");

int Fact(int number)
{
    int fact = 1;
    for( int i = 1; i <= number; i++)
    {
        fact = fact * i;
    }
    return fact;
}

System.Console.WriteLine($"произведение всех цифр в числе {number} = {Fact(number)}");
