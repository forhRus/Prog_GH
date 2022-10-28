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

bool check(int num) // отсеиваем двузнанчные числа
{
    if (num < 100)
    {
        Console.WriteLine($"В числе нет третьей цифры.");
        return false;
    }
    else return true;
}


int Result(int num) // функция на поиск и вывод третьей цифры в числе.
{
    int thirtyDig = number;
    if (check(number))
    {
        while (thirtyDig > 999)        
        {
            thirtyDig = thirtyDig / 10;
        }
        thirtyDig = thirtyDig % 10;
    }
    return thirtyDig;
}
Console.WriteLine($"третья цифра {Result(number)}.");
