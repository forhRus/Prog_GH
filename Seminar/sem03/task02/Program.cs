// Задача 2: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool ValidateQuarter(int q)
{
    if (q > 0 && q < 5) return true;
    else
    {
        Console.WriteLine("Введено не корректное значение.");
        return false;
    }
}

(int, int) FindQuarter(int q)
{
    if (q == 1) return (1, 1);
    if (q == 2) return (-1, 1);
    if (q == 3) return (-1, -1);
    return (1, -1);
}

int quarter = Prompt("Введите четверть => ");

if (ValidateQuarter(quarter))
{
    (int x, int y) = FindQuarter(quarter);
    Console.WriteLine($"Для четверти {quarter} используйте шаблон {x}, {y}.");
}