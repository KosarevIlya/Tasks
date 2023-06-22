// Задача 65. Написать программу, которая выведет все натуральные числа от М до N


// Например М=1 N => 5 "1,2,3,4,5"
//  М= 4 N=>6 "4,5,6"



Console.WriteLine("Введите первое натуральное число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число");
int number2 = Convert.ToInt32(Console.ReadLine());

NatureNumber(number1, number2);


void NatureNumber(int num1, int num2)
{
    if (num1 < num2)
    {
        // if (num2 == num1-1) return;
        NatureNumber(num1, num2 - 1);
        Console.Write($"{num2}   ");
    }
    else if (num1 > num2)
    {
        // if (num2 - 1 == num1) return;

        NatureNumber(num1 - 1, num2);
        Console.Write($"{num1}   ");
    }
    else
    {
        Console.Write($"{num1}   ");
        // return;

    }
}