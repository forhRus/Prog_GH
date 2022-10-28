// 3. Напишите программу, которая будет принимать на вход два числа
//  и выводить, является ли второе число кратным первому. Если число 2
//  не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number; 
}

int num1 = Prompt("Введите первое число > ");
int num2 = Prompt("Введите второе число > ");

void crat(int a, int b)
{
    double ost = a % b;
    if(ost == 0) Console.WriteLine($"число {a} кратно {b}.");
    else Console.WriteLine($"число {a} не кратно {b}. Остаток {ost}.");
}

crat(num1, num2);
