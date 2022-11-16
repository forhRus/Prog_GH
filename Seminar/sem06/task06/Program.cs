// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}



int Fibanacci(int length)
{
    if(length==0) return 0;
    if (length < 2) return 1;
    return Fibanacci(length - 1) + Fibanacci(length - 2);
}
void PrintFibanacci(int length)
{
    for (int i = 0; i < length; i++)
    {
        System.Console.Write($"{Fibanacci(i)} ");
    }
    System.Console.WriteLine();
}

// int RecFib(int n)
// {
//     if (n == 1) return 1;
//     if (n == 2) return 1;
//     int n1 = RecFib(n-2);
//     int n2 = RecFib(n-1);
//     return n1+n2;


// }

int length = Prompt("Сколько чисел из последовательности Фибоначи показать? -> ");
PrintFibanacci(length);
// System.Console.Write(RecFib(number));


