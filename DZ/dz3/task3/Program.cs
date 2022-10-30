// Задача 3: Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125

int Prompt(string massege) //функция на ввод значения с консоли.
{
    System.Console.Write(massege);
    return int.Parse(Console.ReadLine());
}

int number = Prompt("Введите число больше 0 > "); // задаём число с консоли.

bool Validate(int number) // функция для проверки положительности числа.
{
    if (number > 0) return true;
    return false;
}

void Power(int number) // выводим последовательность чисел "number" раз
{
    if (Validate(number))
    {
        for (int i = 1; i <= number; i++)
        {
            System.Console.Write($"{Math.Pow(i, 3)} "); //возводим в третью степень каждый шаг "i"
        }
        System.Console.WriteLine();
    }
    else System.Console.WriteLine("Некорректные данные.");
}

Power(number);