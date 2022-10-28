// 3.1. Напишите программу, которая будет принимать 
// на вход пять чисел и выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4 
int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int count = 1;
double sum = 0;

while (count <= 5)
{
    int a = Prompt($"Введите число {count} > ");
    sum += a;
    count++;
}

double average = sum / (count - 1);
Console.WriteLine(count);
Console.WriteLine($"сумма {sum}, среднее арифметическое {average}");
