// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число");
int number2 = Convert.ToInt32(Console.ReadLine());


int SummBetweenNumber (int numA, int numB)
{
if (numA==numB) return numA;
return numA  + SummBetweenNumber(numA+1, numB);
}


int resault = SummBetweenNumber(number1, number2);
Console.WriteLine($"Сумма натуральных чисел между {number1} и {number2} составляет {resault}");