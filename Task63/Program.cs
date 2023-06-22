// Задача 63. Написать программу, которая выведет все натуральные числа от 1 до N

// Например N => 5 "1,2,3,4,5"
// N=>6 "1,2,3,4,5,6"

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
NatureNumber(number);


void NatureNumber (int num)
{

    if (num == 0) return;
    NatureNumber(num-1);
    Console.Write($"{num}   " );
}