// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray(int rows, int columns)
{
    int[,] tempArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            tempArray[i, j] = new Random().Next(0, 20);
        }
    }
    return tempArray;
}

void PrintDiArray(int[,] array)
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

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

double[] AverageArray(int[,] array)
{
    double[] tempArray = new double[array.GetLength(1)];
    double sum;
    for (int columns = 0; columns < array.GetLength(1); columns++)
    {
        sum = 0;
        for (int rows = 0; rows < array.GetLength(0); rows++)
        {
            sum += array[rows, columns];
        }
        tempArray[columns] = sum / array.GetLength(0);
    }
    return tempArray;
}

int row = 2;
int columns = 5;
int[,] myArray = CreateArray(row, columns);
PrintDiArray(myArray);
System.Console.WriteLine("Средние арифметические значения.");
double[] arrayAverage = AverageArray(myArray);
PrintArray(arrayAverage);


