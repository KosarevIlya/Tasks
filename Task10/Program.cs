// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Ведите трёхзначное число=");
int number = Convert.ToInt32(Console.ReadLine());
Console .WriteLine 
($"Вторым числом является {Secondnumber(number)}");


int Secondnumber (int num)

{
    return num / 10 % 10;
}