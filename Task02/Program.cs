// Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, а 
// какое меньшее.


Console.WriteLine("Введите первое число = ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Ведите второе число = ");
int b = Convert.ToInt32 (Console.ReadLine());

if (a > b )  Console.WriteLine("Первое число больше второго");

else if (b>a) Console.WriteLine("Второе число больше первого");
else Console.WriteLine("Числа равны");
    
