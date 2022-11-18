// Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] FillArray(int m, int n)
{
    int[,] tempArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            tempArray[i, j] = new Random().Next(1, 10);
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
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int SumElementDiagonale(int[,] array)
{
    int[,] tempArray = new int[array.GetLength(0), array.GetLength(1)];
    int sum = 0;
    int j = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        sum += array[i, j++];

    }
    return sum;
}

int m = 3;
int n = 3;
int[,] myArray = FillArray(m, n);
PrintArray(myArray);

System.Console.WriteLine(SumElementDiagonale(myArray));

