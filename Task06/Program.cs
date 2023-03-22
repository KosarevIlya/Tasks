// Напишите программу, которая на вход 
// принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

Console.WriteLine("Введите  число = ");
int a = Convert.ToInt32 (Console.ReadLine());
double b = a % 2;
if (b == 0) Console.WriteLine("Число является четным");
else Console.WriteLine ("Число является нечетным");