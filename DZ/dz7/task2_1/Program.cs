// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 и 7 -> такого числа в массиве нет
int Prompt(string msg)
{
    System.Console.Write(msg);
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

void FindElement(int[,] array, int rowN, int columnN)
{
    if (rowN <= 0
    || rowN > array.GetLength(0)
    || columnN <= 0
    || columnN > array.GetLength(1)) System.Console.WriteLine("Такого элемента в массиве нет.");
    else
    {
        System.Console.WriteLine($"Искомый элемент - {array[rowN - 1, columnN - 1]}");
    }
}

int row = 2;
int column = 5;
int[,] myArray = FillArray(row, column);
PrintArray(myArray);
int rowInput = Prompt($"Введите номер строки -> ");
int columnInput = Prompt($"Введите номер столбца -> ");
FindElement(myArray, rowInput, columnInput);
