// Задача 6*: Напишите программу, которая генерирует 
// последовательность случайных чисел до тех пор, 
// пока не сгенерирует кратное число введенному в начале.

int Prompt(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

int crat = Prompt("Введите число от 1 до 10 > ");

void Starter()
{
    while (true)
    {
        int num = new Random().Next(1, 11);
        if (num % crat == 0)
        {
            System.Console.WriteLine(num);
            break;
        }
        System.Console.WriteLine($"пока не получилось = {num}");
    }
}
Starter();



