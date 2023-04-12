// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine ("Введите значение первой точки");
Console.WriteLine ("Введите значение точки Х =");
int xPointA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите значение точки Y=");
int yPointA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите значение точки C=");
int cPointA = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите значение Второй точки");
Console.WriteLine ("Введите значение точки Х =");
int xPointB = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите значение точки Y=");
int yPointB = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите значение точки C=");
int cPointB = Convert.ToInt32 (Console.ReadLine());

double distant = Distant(xPointA, yPointA, xPointB, yPointB, cPointA, cPointB);

Console.WriteLine ($"Расстояние между двумя точками {Math.Round(distant, 2, MidpointRounding.ToZero)}");
double Distant (int xA, int yA, int xB, int yB, int xC, int yC)
{
    return Math.Sqrt (Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) +
    Math.Pow(xC - yC, 2));
}
