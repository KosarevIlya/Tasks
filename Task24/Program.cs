// Введите натуральное число А, которое на выходе дает сумму всех натуральных чисел от 1 до А
// 7--> 28
// 4->10


Console.WriteLine ("Введите значение числа А=");
int pointA = Convert.ToInt32 (Console.ReadLine());

int sumNumbers = SumNumbers(pointA);   
Console.WriteLine ($" Сумма чисел = {sumNumbers}");
int SumNumbers( int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    { 
        sum += i;
    }
    return sum;

}

