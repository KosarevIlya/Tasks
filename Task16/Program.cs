// Написать программу, по которой нужно взять два числа и определить
// является ли одно число квадратом второго

Console.WriteLine("Введите первое число=");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число=");
int second = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Sqrt(first, second) ? "Да" : "Нет");

bool Sqrt(int first1, int second2)
{

    return first1 * first1 == second2 || second2*second2==first1;
}