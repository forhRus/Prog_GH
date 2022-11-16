// Найдите максимальное значение в матрице по каждой строке, 
// получите сумму этих максимумов. Затем найдите минимальное значение по каждой колонке,
// получите сумму этих минимумов. Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2


void PrintDiArray(int[,] arr) //функци выводит двухмерный массив
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine("");
    }
}

int[,] CreateDiArray(int[] arr) // функция заполняет двумерный массив [2, 3] заданными числами по условию
{
    int[,] tempArray = new int[2, 3];
    int length = 0;
    for (int j = 0; j < tempArray.GetLength(0); j++)
    {
        for (int h = 0; h < tempArray.GetLength(1); h++)
        {
            tempArray[j, h] = arr[length];
            length++;
        }
    }
    return tempArray;
}

int[] FindMaxNumbers(int[,] arr) //ищем максимумы в строчках и записываем их в массив.
{
    int[] tempArray = new int[arr.GetLength(0)];
    int max = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        max = arr[i, 0];
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (max < arr[i, j]) max = arr[i, j];
        }
        tempArray[i] = max;
    }
    return tempArray;
}

int[] FindMinNumbers(int[,] arr) //ищем минимумы в столбцах и записываем их в массив.
{
    int[] tempArray = new int[arr.GetLength(1)];
    int min = arr[0, 0];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        min = arr[0, i];
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            if (min > arr[j, i]) min = arr[j, i];
        }
        tempArray[i] = min;
    }
    return tempArray;
}

int SumNumbers(int[] arr) // вычисляем сумму элементов массив
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
}

int[] array = { 1, 2, 3, 3, 4, 5 }; // чтобы ручками не вводить и не присваивать двухмерному массиву элементы поотдельности, возьму значения из одномерного.
int[,] myArray = CreateDiArray(array); //заполняю двухмерный массив
PrintDiArray(myArray); //вывожу массив
int[] maxNumbersRow = FindMaxNumbers(myArray); //ищу максимальные числа в строках
int sumRow = SumNumbers(maxNumbersRow); //суммирую их
int[] minNumbersColumn = FindMinNumbers(myArray); //ищу минимальные числа в столбцах
int sumColumn = SumNumbers(minNumbersColumn); //суммирую их

System.Console.WriteLine($"Сумма максимумов строк равна {sumRow}."); //вывод суммы максимумов
System.Console.WriteLine($"Сумма минимумов столбцов равна {sumColumn}."); //вывод суммы минимумов
System.Console.WriteLine($"Разница максимумов и минимумов равна {sumRow - sumColumn}."); //выводы разницы сумм.
