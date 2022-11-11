// Задача 4: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и 
// т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int legth = 11;
int min = 0;
int max = 10;

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");
    }
    System.Console.WriteLine("");
}

int[] NewArray(int[] array)
{
    int[] newArr = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = array[i] * array[array.Length - 1 - i];
    }
    return newArr;
}

int[] array = CreateArray(legth, min, max);
PrintArray(array);
int[] newArr = NewArray(array);
PrintArray(newArr);
