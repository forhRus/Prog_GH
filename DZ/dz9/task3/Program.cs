//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string massege) // функция на ввод числа с консоли
{
    System.Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}

int FAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FAkkerman(m - 1, 1);
    else return FAkkerman(m - 1, FAkkerman(m, n - 1));
}

bool ValidateMN(int m, int n)
{
    if (m < 0 || n < 0) return false;

    return true;
}
int m = Prompt("Задайте m -> ");
int n = Prompt("Задайте n -> ");


if (ValidateMN(m, n))
{
    System.Console.WriteLine(FAkkerman(m, n));
}
else System.Console.WriteLine("Eror!");
