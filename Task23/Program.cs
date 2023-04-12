// Задача 23

// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine ("Введите значение числа N =");
int Number = Convert.ToInt32 (Console.ReadLine());

Cube(Number);
void Cube (int num)
{
int result = 0;
int index = 1;
while (index <= num)
{
    result = index * index * index;
    Console.WriteLine ($"{index, 5} и его куб {result, 5}");
    index++;
    }

}
