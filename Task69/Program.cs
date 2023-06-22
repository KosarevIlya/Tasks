// Задача 69. Напишите программу, которая на вход принимает два целых числа А и В и возводит
// А в степень В.
// Например 2 и 3. = 8
// А = 3 В = 5 -> 243


Console.WriteLine("Введите первое натуральное число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число");
int number2 = Convert.ToInt32(Console.ReadLine());


int PowNumber (int numA, int numB)
{
if (numB==1) return numA;
return numA *PowNumber(numA, numB-1);
}


int resault = PowNumber(number1, number2);
Console.WriteLine($"Число {number1} в степени {number2} составляет {resault}");

