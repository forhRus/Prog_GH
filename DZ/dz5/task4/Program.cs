// Задача 4 (*) При помощи рекурсии вывести последовательность чисел, с заданым количеством этих чисел по принципу:
// Ввожу => 12
// 1 2 2 3 3 3 4 4 4 4 5 5

int Prompt(string message)
{
    System.Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void Numbers(int length)
{
    int count = 0;
    int i = 1;
    while (true)
    {
        for (int j = 0; j < i; j++)
        {
            System.Console.Write($"{i} ");
            count++;
            if (count == length)
            {
                System.Console.WriteLine("");
                return;
            }
        }
        i++;
    }
}

int length = Prompt("Введите количество чисел в последовательности -> ");
Numbers(length);

//Тему с рекурсией не очень понял.