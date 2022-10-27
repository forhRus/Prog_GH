// 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number; 
}

int num = Prompt("Введите число > ");

void crat(int a)
{
    double ost = a % 7;
    if(ost == a % 23) Console.WriteLine($"число {a} кратно одновременно 7 и 23.");
    else Console.WriteLine($"число {a} не кратно одновременно 7 и 23.");
}

crat(num);
