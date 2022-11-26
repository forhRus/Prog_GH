// Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

int Prompt(string massege) // функция на ввод числа с консоли
{
    System.Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}

bool ValExp(double n)
{
    if (n == 1) return true;
    if (n == 2) return true;
    return (n % 2 == 0 && ValExp(n / 2));
}

double number = Prompt("Число -> ");
if (ValExp(number)) System.Console.WriteLine("Yes");
else System.Console.WriteLine("No");
