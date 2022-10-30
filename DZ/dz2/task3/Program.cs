// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

int Prompt(string message) // функция на ввод числа
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Prompt("Введите число > "); //присваиваем значение через ввод числа

bool check(int num) // отсеиваем двузначные числа
{
    if (num > 99 || num < -99) return true;
    return false;
}

void Result(int num) // функция на поиск и вывод третьей цифры в числе.
{
    if (check(num))
    {
        int thirtyDig = num;
        if (thirtyDig < 0) thirtyDig = thirtyDig * -1;
        while (thirtyDig > 999)
        {
            thirtyDig = thirtyDig / 10;
        }
        thirtyDig = thirtyDig % 10;
        Console.WriteLine($"третья цифра {thirtyDig}.");
    }
    else Console.WriteLine($"В числе нет третьей цифры.");
}

Result(number);