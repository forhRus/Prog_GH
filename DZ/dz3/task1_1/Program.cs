// Задача 1: Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, является ли оно палиндромом.

int Prompt(string massege) // функция на ввод числа с консоли
{
    System.Console.Write(massege);
    return int.Parse(Console.ReadLine());
}

int number = Prompt("Введите пятизначное число > "); //задаём число

int Revers(int number)
{
    int answer = 0;
    while(number > 0)
    {
        answer = answer *10 + number%10;
        number /=10;
    }
    return answer;
}

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

void CheckPal(int num) //сравниваем число и его "палиндром"
{
    if (Validate(num)) //проверка
    {
        if (Revers(num) == num) System.Console.WriteLine($"число {number} - палиндром. Для наглядности {Revers(num)}"); // вывод палиндром
        else System.Console.WriteLine($"число {number} - непалиндром. Для наглядности {Revers(num)}"); //вывод не палиндром
    }
}

CheckPal(number); //зовём проверку числа - палиндром ли оно?
