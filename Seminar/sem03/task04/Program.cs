// Задача 4: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Prompt(string massege)
{
    System.Console.Write($"{massege}");
    return int.Parse(Console.ReadLine());
}

void fractal(int num)
{
    if(num < 0) num *= -1;
    if(num > 0)
    {
        
        int i = 1;
        while(i <= num)
        {
            Console.Write($"{Math.Pow(i, 2)} ");
            i++;
        }
        System.Console.WriteLine("");
    }
    else System.Console.WriteLine("Введён 0.");
}

int number = Prompt("Введите число > ");
fractal(number);
