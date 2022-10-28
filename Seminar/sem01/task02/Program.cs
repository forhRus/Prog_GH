System.Console.WriteLine("What is day today? 1-7 >");
int n = Convert.ToInt32(Console.ReadLine());
string[] days = { "пн", "вт", "ср", "чт", "пт", "сб", "вс" };

if (n > 0 && n < 8) 
{
    Console.WriteLine(days[n-1]);
}
else
{
    Console.WriteLine("некоректные данные. введите от 1 до 7!");
}
