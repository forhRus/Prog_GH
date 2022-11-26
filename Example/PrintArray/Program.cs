void PrintArray(int[] array)
{
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");
    }
    System.Console.WriteLine("");
}

void PrintArrayForeach(int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write($"{array[item]} ");
    }
    System.Console.WriteLine();
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


