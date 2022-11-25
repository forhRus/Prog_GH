// Задача 4: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] CreateMatrix(int rows, int cols, int min, int max)
{
    int[,] tempMatrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            tempMatrix[i, j] = new Random().Next(min, max);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrix) //функци выводит двухмерный массив
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


(int, int) FindMinNumberOfMatrix(int[,] matrix)
{
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[minI, minJ] > matrix[i, j])
            {
                minI = i;
                minJ = j;
            }
        }
    }
    return (minI, minJ);
}

int[,] GetMatrixDeletIJ(int[,] matrix, int indexI, int indexJ)
{
    int[,] tempMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (indexI != i && indexJ != j)
            {
                int k = i;
                int l = j;
                if(k> indexI) k--;
                if(l> indexJ) l--;
                tempMatrix[k, l] = matrix[i, j];
            }
        }
    }
    return tempMatrix;
}

int[,] myMatrix = CreateMatrix(4, 4, 0, 10);
PrintMatrix(myMatrix);
(int i, int j) = FindMinNumberOfMatrix(myMatrix);
int[,] newMatrix = GetMatrixDeletIJ(myMatrix, i, j);
System.Console.WriteLine();
PrintMatrix(newMatrix);