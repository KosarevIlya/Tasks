// Напишите программу, которая на вход 
// принимает число (N), а на выходе показывает все чётные 
// числа от 1 до N.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

int number = 2;
Console.WriteLine("Все  четные числа до введенного числа");
while (number <= N)
{
    Console.Write ($"  {number}");
    number = number + 2;
}