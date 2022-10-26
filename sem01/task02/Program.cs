System.Console.WriteLine("What is day today? 1-7 >");
string day = Console.ReadLine();
int num = Convert.ToInt32(day);

int mon = 1;
int the = 2;
int wen = 3;
int thu = 4;
int fry = 5;
int sut = 6;
int sun = 7;

if (num == mon) System.Console.WriteLine("today is Monday");
if (num == the) System.Console.WriteLine("today is Thesday");
if (num == wen) System.Console.WriteLine("today is Wensday");
if (num == thu) System.Console.WriteLine("today is Thusday");
if (num == fry) System.Console.WriteLine("today is Fryday");
if (num == sut) System.Console.WriteLine("today is Suterday");
if (num == sun) System.Console.WriteLine("today is Sunday");     
if (num <1 || num > 7) System.Console.WriteLine("eror!"); 
