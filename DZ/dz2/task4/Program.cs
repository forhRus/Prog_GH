// Задача 4: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message) // функция на ввод числа
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int day = Prompt("Введите день недели от 1 до 7. > ");

bool check(int num) // проверка диапозона
{
    if (num > 0 && num <= 7) return true;
    else return false;
}

if (check(day)) //результат
{
    if (day == 6 || day == 7) Console.WriteLine("Выходной день.");
    if (day >= 1 && day <= 5) Console.WriteLine("Солнце ещё высоко. Работай.");
}
else Console.WriteLine("Некоректные данные.");

// if (day == 6 || day == 7) Console.WriteLine("Выходной день.");
// if (day >= 1 && day <= 5) Console.WriteLine("Солнце ещё высоко. Работай.");
// if (day < 1 || day > 7) Console.WriteLine("Некоректные данные.");
