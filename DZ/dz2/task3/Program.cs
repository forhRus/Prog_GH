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

// bool check(int num) //проверка числа.
// {
//     if (num < -99 || num > 99) return true;
//     else return false;
// }

void res(int num)
{
    num = num / 100;
    if (num == 0)
    {
        Console.WriteLine($"Некорректные данные. Введёное число не трёхзначное.");
    }
    else
    {
        int dig3 = num % 10;
        Console.WriteLine($"третья цифра {dig3}.");
    }
}
res(number);
