// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(int len) // создаём через ввод пользователем массив 'len' длины 
{
    int[] tempArr = new int[len];
    for (int i = 0; i < len; i++)
    {
        tempArr[i] = Prompt($"Введите {i} элемент массива -> ");
    }
    return tempArr;
}

int CounterPos(int[] arr) //считаем положительные числа в массиве
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) counter++;
    }
    return counter;
}

int length = Prompt("Введите длину массива -> ");
int[] myArray = CreateArray(length);
System.Console.WriteLine($"Количество положительных чисел в массиве - {CounterPos(myArray)}.");

