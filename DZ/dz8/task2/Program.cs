// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


int[] sumArray(int[,] matrix) //считаем сумму в строках и помещаем результат в массив
{
    int[] tempArray = new int[matrix.GetLength(0)];
    int summa;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        summa = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summa += matrix[i, j];
        }
        tempArray[i] = summa;
    }
    return tempArray;
}

int SearchRowsMinSum(int[] array) //ищем минимальный элемент в массиве
{
    int indexMinSum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[indexMinSum] > array[i]) indexMinSum = i;
    }
    return indexMinSum;
}



int[,] myMatrix = CreateMatrix(4, 4, 0, 10);
PrintMatrix(myMatrix);
System.Console.WriteLine($"Наименьшая суммой элементов: {SearchRowsMinSum(sumArray(myMatrix)) + 1} строка.");
