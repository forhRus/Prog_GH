// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int Prompt(string msg)
{
    System.Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int[,] FillArray(int row, int column)
{
    int[,] tempArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            tempArray[i, j] = new Random().Next(0, 50);
        }
    }
    return tempArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void FindElement(int[,] array, int number)
{
    if (number <= 0
        || number > array.GetLength(0) * array.GetLength(1))
        System.Console.WriteLine("Элемента с таким порядковым номером в нашем массиве не существует!");
    else
    {
        int i = (number - 1) / array.GetLength(1);
        int j = (number - 1) - array.GetLength(1) * i;
        System.Console.WriteLine($"Элемент с номером {number} - {array[i, j]} для проверки его индексы [{i}, {j}]");
    }
}

int row = 2;
int column = 5;
int[,] myArray = FillArray(row, column);
PrintArray(myArray);
int number = Prompt($"Введите номер элемента от 1 до {row * column} -> ");
FindElement(myArray, number);
