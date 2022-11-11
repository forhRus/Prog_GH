// Задача 2: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");
    }
    System.Console.WriteLine("");
}

bool FindNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }
    return false;
}

void PrintResult(int[] array, int number)
{
    if (FindNumber(array, number)) System.Console.WriteLine($"Число {number} присутствует в массиве.");
    else System.Console.WriteLine($"Число {number} отсутсвует в массиве.");
}

int len = 10;
int min =0;
int max = 9;
int[] array = CreateArray(len, min, max);
PrintArray(array);
int number = Prompt("Какое число вы хотите найти? -> ");
PrintResult(array, number);