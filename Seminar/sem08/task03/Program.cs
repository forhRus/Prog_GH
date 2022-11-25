// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных. Значения элементов массива 0..9
//  Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

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

int[,] CreateMatrix(int intI, int intJ, int min, int max) //создаём массив.
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

void CounterMatrixNumber(int[,] matrix)
{
    int tempNumber = 0;
    int counter;
    while (tempNumber < 10)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            counter = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (tempNumber == matrix[i, j]) counter++;
            }
            if (counter > 0) System.Console.WriteLine($"{tempNumber} встречается {counter} раз.");
        }
        tempNumber++;
    }

}



int rows = PromptInt("Задайте число строк -> ");
int columns = PromptInt("Задайте число столбцов -> ");

if (ValidateMatrixIJ(rows, columns))
{
    int minNumber = 0;
    int maxNumber = 10;
    int[,] myMatrix = CreateMatrix(rows, columns, minNumber, maxNumber);
    PrintMatrix(myMatrix);
    System.Console.WriteLine();
    CounterMatrixNumber(myMatrix);
}


