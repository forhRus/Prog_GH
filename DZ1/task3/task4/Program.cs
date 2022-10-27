// Задача 4: Напишите программу, которая на вход принимает число (N), 
//           а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите число > ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 2;

if(i <= num)
{
    while(i <= num)
    {
        if(i == num) Console.WriteLine(i + ".");
        else Console.Write(i + ", ");
        i+=2;
    }
}
else
{
    Console.WriteLine($"{num} должно быть больше 1"); 
}
