// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());    
}

int[] CreateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = i + 1;
    }
    return array;
}

int[] ReversArray(int[] array)
{
    int[] tempArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        tempArray[i] = array[array.Length - 1 - i];
    } 
    return tempArray;
}

void PrintArray(int[] array)
{
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write(", " + array[i]);
    }
    System.Console.WriteLine("");
}

int[] array = CreateArray(Prompt("Введите длину массива -> "));
PrintArray(array);
PrintArray(ReversArray(array));
