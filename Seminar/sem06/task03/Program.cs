// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int BinarNum(int num)
{
    int biNum = 0;
    while (num > 0)
    {
        biNum += num % 2;
        num /= 2;
        if (num > 0) biNum *= 10;
    }
    return biNum;
}

int number = Prompt("Введите число -> ");
System.Console.WriteLine(BinarNum(number));