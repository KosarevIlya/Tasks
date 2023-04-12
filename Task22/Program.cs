// напишите программу, которая на входе принимает число(N) и выдает таблицу
// егочисел от 1 до N 

Console.WriteLine ("Введите значение числа N =");
int Number = Convert.ToInt32 (Console.ReadLine());

Quart(Number);
void Quart (int num)
{
int result = 0;
int index = 1;
while (index <= num)
{
    result = index * index;
    Console.WriteLine ($"{index, 5} и его квадрат {result, 5}");
    index++;
    }

}