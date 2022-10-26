System.Console.Write("Give me num1 > ");
string inNum1 = Console.ReadLine();
int a = Convert.ToInt32(inNum1);

System.Console.Write("Give me num2 > ");
string inNum2 = Console.ReadLine();
int b = Convert.ToInt32(inNum2);

if (a * a == b)
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}
