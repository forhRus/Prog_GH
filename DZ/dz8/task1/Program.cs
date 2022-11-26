// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

int[,] StreamlineMatrix(int[,] matrix)
{
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        temp = 0;
        while (temp < matrix.GetLength(1)) //перемещаем большее число в левую часть массива. повторяем столько раз, сколько элементов в строке.
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > matrix[i, j - 1]) (matrix[i, j], matrix[i, j - 1]) = (matrix[i, j - 1], matrix[i, j]);
            }
            temp++;
        }
    }
    return matrix;
}



int[,] myMatrix = CreateMatrix(3, 7, 0, 30);
PrintMatrix(myMatrix);
System.Console.WriteLine();
PrintMatrix(StreamlineMatrix(myMatrix));