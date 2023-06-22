// Задача 67. Напиште программу, которая на вход принимает  число и на выход
// выдает сумму составляющих его цифр
// Например : 121 = 1+2+1 = 4


Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());


int SumNumbers (int num)
{
    if (num==0 ) return 0;
    
    return num % 10 + SumNumbers(num /10);
}

SumNumbers (number);
int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма цифр в числе {number} составляет {sumNumbers}");
