// Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

(double, double) Prompt(string msg1, string msg2) //функция на ввод переменной и степени
{
    System.Console.Write($"Введите значения для переменой {msg1} -> ");
    double x = Convert.ToInt32(Console.ReadLine());
    System.Console.Write($"Введите значения {msg2} для возведения {msg1} в эту степень -> ");
    double n = Convert.ToInt32(Console.ReadLine());
    return (x, n);
}

bool Validate(double x, double n) //проверка на недопустимые значения
{
    if (x == 0 && n < 0)
    {
        System.Console.WriteLine($"{x} Недопустимое значение для переменной в отрицательной степени");
        return false;
    }
    return true;
}

double Pow(double x, double n) //функция на возведение в степень
{
    if (n == 0) return 1;
    double multi = x;
    if (n > 0)
    {
        for (int i = 1; i < n; i++)
        {
            multi = multi * x;
        }
    }
    if (n < 0)
    {
        multi = 1 / multi;
        for (int i = -1; i > n; i--)
        {
            multi = multi / x;
        }
    }
    return multi;
}

(double x, double n) = Prompt("x", "n"); //присваиваем значения

if (Validate(x, n)) //проверка значений
{
    System.Console.WriteLine($"{x} ^ {n} = {Pow(x, n)} "); //вывод результата
}
