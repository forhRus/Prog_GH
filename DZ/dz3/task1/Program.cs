// Задача 1: Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, является ли оно палиндромом.

int Prompt(string massege) // функция на ввод числа с консоли
{
    System.Console.WriteLine(massege);
    return int.Parse(Console.ReadLine());
}

int number = Prompt("Введите пятизначное число > "); //задаём число

int Counter(int num) //счётчик цифр в числе
{
    int count = 0;
    while (num > 0 || num < 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

bool Validate(int num) // функция для проверки на пятизначность. позволяет работать с отрицательными числами.
{
    int count = Counter(num);
    if(count == 5) return true;
    else
    {
        System.Console.WriteLine($"Число {num} не пятизначное.");
        return false;
    }
}

int Pal(int num) //функция на разворот числа / хотел через массив решить, но не справился.
{
    int pal = 0; // будущий "палиндром"
    int x = num;
    for (int i = 0; i < 5; i++) //разворачиваем число
    {
        pal = pal + x % 10; // каждый раз добавляем остаток
        if (i < 4) pal = pal * 10; //чтобы не получился палиндом с нулём на конце, 5ую цифру только прибавляем
        x = x / 10; //уменьшаем число
    }
    return pal;
}

void CheckPol(int num) //сравниваем число и его "палиндром"
{
    if (Validate(num)) //проверка
    {
        if (Pal(num) == num) System.Console.WriteLine($"число {number} - палиндром. Для наглядности {Pal(num)}"); // вывод палиндром
        else System.Console.WriteLine($"число {number} - непалиндром. Для наглядности {Pal(num)}"); //вывод непалиндром
    }
}

CheckPol(number); //зовём проверку на палиндромность заданного числа
