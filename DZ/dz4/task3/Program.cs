// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
(int, int, int) Prompt(string message) // ввод с консоли длину массива, минимальное и максимальное значениение.
{
    System.Console.Write(message + "количество элементов массива -> ");
    int length = Convert.ToInt32(Console.ReadLine());
    System.Console.Write(message + "минимальное значение элемента -> ");
    int min = Convert.ToInt32(Console.ReadLine());
    System.Console.Write(message + "максимальное значение элемента -> ");
    int max = Convert.ToInt32(Console.ReadLine());
    return (length, min, max);
}

bool Validate(int length) //проверка на отрицательное значение длины массива.
{
    if (length < 0)
    {
        System.Console.WriteLine("Некоректные данные. Значение длины массива отрицательное");
        return false;
    }
    return true;
}

int[] CreatArray(int length, int min, int max) //функция создаёт массив по заданным параметрам
{
    int[] array = new int[length];
    if (length == 0) return array;
    if (min > max) // меняем местами мин и макс занчения, если они перепутаны.
    {
        int top = min;
        min = max;
        max = top;
    }
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1); // добавил +1, чтобы введённое максимальное значениебыло включительно.
    }
    return array;
}

void PrintArray(int[] array) // печатем массив
{
    if (array.Length == 0) System.Console.WriteLine("Массив пустой"); // если массив пустой.
    else //
    {
        System.Console.Write(array[0]);
        for (int i = 1; i < array.Length; i++)
        {
            System.Console.Write($", {array[i]}");
        }
        System.Console.WriteLine("");
    }

}

(int length, int min, int max) = Prompt("Задайте "); //вызываем ввод параметров массива

if (Validate(length)) // првоерка на длину массива.
{
    int[] myArray = CreatArray(length, min, max);
    PrintArray(myArray);
}


