// Задача 19

// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
// 13 % 5 = 3
Console.WriteLine ("Введите пятизначное число N =");
int num = Convert.ToInt32 (Console.ReadLine());

Palidrom(num);
Console.WriteLine (Palidrom(num));

bool Palidrom (int z)
{
    int c = 0;
    int b = z;
    while (z > 0)
{
    int remains = z % 10;
    z = (z - remains) /10;
    c = c*10 + remains;

}
    
    return c == b;
}
   