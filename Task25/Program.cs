// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число, которое хотите возвести в степень. А =");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень, в которую хотите возвести. B =");
int numberB= Convert.ToInt32(Console.ReadLine());

int expo = ExponentiationOfANumber(numberA, numberB);
Console.WriteLine ($"Возведенное в степень В число А = {expo}");

int ExponentiationOfANumber (int numA, int numB)
{
    int exponentiatiot = 1;
    for (int i = 0; i < numB; i++)
    {
        
        exponentiatiot = exponentiatiot * numA;
    }
    return exponentiatiot;
}