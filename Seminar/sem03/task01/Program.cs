// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool ValidateCoord(int x, int y)
{
    if (x == 0 || y == 0)
    {
        Console.WriteLine("Точка находиться на одной из координатных прямых");
        return false;
    }
    return true;
}

int GetQuarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x > 0 && y < 0) return 4;
    return 3;
}

int x = Prompt("Введите х => ");
int y = Prompt("Введите y => ");

if (ValidateCoord(x, y))
{
    int quarter = GetQuarter(x, y);
    Console.WriteLine($"кородината находится в {quarter} четверти.");
}
