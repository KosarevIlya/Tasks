// Задача 40 Напишите программу, которая на вход принимает три числа и проверяет, может ли существовать треугольник
// со сторонами такой длинны
// Теорема о неравенстве треугольника - каждая сторона треугольника меньше суммы двух других сторон

Console.WriteLine ("Введите длину первой стороны = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите длину второй стороны = ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите длину третей  стороны = ");
int c = Convert.ToInt32(Console.ReadLine());

bool RealityTriangle(int a, int b, int c)
{
 if (a+b > c && c +b > a && a +c > b) return true;
 else return false;
}

string output = RealityTriangle(a,b,c) ? "Отрезки могут являтся сторонами треугольника" : "Отрезки не могут являтся стронами треугольника";

Console.WriteLine(output);