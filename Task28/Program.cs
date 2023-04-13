// Написать программу, которая на входе принимает число N и на выходе
// выдает произведение чисел от 1 до N,


Console.WriteLine ("Введите значение числа N =");
int num = Convert.ToInt32 (Console.ReadLine());

int arraySum = ArraySum(num);
Console.WriteLine($"Произвдение чисел от 1 до {num} = {arraySum}");


int ArraySum (int numA)
{
int sum = 1;
for (int i = 1; i <= numA; i++)
{ 
    checked
    {
        sum = sum * i;
    }
    
}
return sum;
}