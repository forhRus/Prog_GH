// Напишите программу вычисления модуля числа.
// 	2 -> 2
// -3 -> 3
// -7 -> 7
Console.Write("Please type the number > ");
int num = Convert.ToInt32(Console.ReadLine());
int mod = num;
if (mod < 0) mod = -num;
Console.WriteLine("modul' chisla " + num + " = " + mod);
