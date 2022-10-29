// Задача 1: Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, является ли оно палиндромом.

int Prompt(string msg) // функция на ввод числа с консоли
{
    System.Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int number = Prompt("Введите пятизначное число > "); //задаём число

bool Validate(int num) // функция для проверки на пятизначность
{
    if(num > 9999 && num < 100000) return true;
    else 
    {
        System.Console.WriteLine($"Число {num} не пятизначное.");
        return false;
    }
}

void CheckPol(int num) //проверяем число. палиндром иль нет
{
    if(Validate(num)) // проверка на пятизначность
    {
        int pol = 0; // будущий "палиндром"
        int x = num;
        for (int i = 0; i < 5; i++) //разворачиваем число
        {
            pol = pol + x % 10;
            if(i < 4) pol = pol * 10;
            x = x / 10;
        }
        if(pol == num) System.Console.WriteLine($"число {number} - палиндром. {pol}"); // вывод палиндром
        else System.Console.WriteLine($"число {number} - непалиндром. {pol}"); //вывод непалиндром
    }
}

CheckPol(number); //зовём проверку заданного числа
