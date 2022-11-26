// Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”

int Prompt(string massege) // функция на ввод числа с консоли
{
    System.Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}

bool CheckSimplNumber(int n, int div)
{
    if (div == 1)
        return true;
    return (n % div != 0 && CheckSimplNumber(n, div - 1));
}

int number = Prompt("Число -> ");
int divider = number - 1;
System.Console.WriteLine(CheckSimplNumber(number, divider));