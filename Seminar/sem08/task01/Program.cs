// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int PromptInt(string massege)
{
    System.Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateMatrixIJ(int i, int j) //проверка на отрицательные значения
{
    if (i > 0 && j > 0) return true;
    return false;
}

int[,] CreateMatrix(int intI, int intJ) //создаём массив.
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

void PrintMatrix(int[,] matrix)
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

int[,] SwitchFirstAndLastRows(int[,] matrix)
{
    int temp;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
    return matrix;
}



int rows = PromptInt("Задайте число строк -> ");
int columns = PromptInt("Задайте число столбцов -> ");
if (ValidateMatrixIJ(rows, columns))
{
    int[,] myMatrix = CreateMatrix(rows, columns);
    PrintMatrix(myMatrix);
    System.Console.WriteLine();
    PrintMatrix(SwitchFirstAndLastRows(myMatrix));
}


