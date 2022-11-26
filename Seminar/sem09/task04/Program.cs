// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Prompt(string massege) // функция на ввод числа с консоли
{
    System.Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}

double PowerNumber(double n, double p)
{
    int znak = 0;
    if (p < 0)
    {
        p = -p;
        znak = 1;
    }
    else if (p == 0)
    {
        return 1;
    }
    else if (p == 1)
    {
        return n;
    }
    if (n == 0)
    {
        return 0;
    }
    if (p / 2 == 0)
    {
        return PowerNumber(n * n, p / 2);
    }
    if (znak == 1)
    {
        return 1 / (n * PowerNumber(n, p - 1));

    }
    return n * PowerNumber(n, p - 1);

}


double number = Prompt("Число -> ");
double power = Prompt("Степень -> ");
System.Console.WriteLine(PowerNumber(number, power));
