// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int PromptInt(string massege)
{
    System.Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateMatrixIJ(int i, int j) //проверка на положительные значения
{
    if (i < 0 || j < 0)
    {
        System.Console.WriteLine("Количество элементов должно быть положительным.");
        return false;
    }
    if (i != j)
    {
        System.Console.WriteLine("Количество строк не равно количеству стобцов.");
        return false;
    }
    return true;
}

int[,] CreateMatrix(int intI, int intJ) //создаёт массив.
{
    int[,] tempMatrix = new int[intI, intJ];
    for (int i = 0; i < intI; i++)
    {
        for (int j = 0; j < intJ; j++)
        {
            tempMatrix[i, j] = new Random().Next(0, 20);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrix) // печатает массив
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] TransposeMatrix(int[,] matrix)
{
    int[,] tempMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            tempMatrix[j, i] = matrix[i, j];
        }
    }
    return tempMatrix;
}

int rows = PromptInt("Задайте число строк -> ");
int columns = PromptInt("Задайте число столбцов -> ");
if (ValidateMatrixIJ(rows, columns))
{
    int[,] myMatrix = CreateMatrix(rows, columns);
    PrintMatrix(myMatrix);
    System.Console.WriteLine();
    PrintMatrix(TransposeMatrix(myMatrix));
}

