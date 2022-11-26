// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrix(int intI, int intJ, int min, int max)
{
    int[,] tempMatrix = new int[intI, intJ];
    for (int i = 0; i < intI; i++)
    {
        for (int j = 0; j < intJ; j++)
        {
            tempMatrix[i, j] = new Random().Next(min, max);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrix) //функция выводит двухмерный массив
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine("");
    }
}


int[,] matrixMultiplication(int[,] matrixA, int[,] matrixB) //
{
    int[,] tempMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            for (int temp = 0; temp < matrixB.GetLength(0); temp++)
            {
                tempMatrix[i, j] += matrixA[i, temp] * matrixB[temp, j];
            }
        }
    }
    return tempMatrix;
}


int[,] firstMatrix = CreateMatrix(3, 2, 0, 10);
PrintMatrix(firstMatrix);
System.Console.WriteLine();
int[,] secondMatrix = CreateMatrix(2, 3, 0, 10);
PrintMatrix(secondMatrix);
System.Console.WriteLine();
int[,] multiMatrix = matrixMultiplication(firstMatrix, secondMatrix);
PrintMatrix(multiMatrix);
