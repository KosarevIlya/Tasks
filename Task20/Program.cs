//double res =5.098764783;

//double resRound = Math.Round (res, 2, MidpointRounding.ToZero);

//Console.WriteLine (resRound);
 
// Напишите программу, которая на входе принимет координаты двух точек и на
// выходе выводит расстояние между ними. С округлением до 2 знаком после 
//запятой

Console.WriteLine ("Введите значение первой точки");
Console.WriteLine ("Введите значение точки Х =");
int xPointA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите значение точки Y=");
int yPointA = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите значение Второй точки");
Console.WriteLine ("Введите значение точки Х =");
int xPointB = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите значение точки Y=");
int yPointB = Convert.ToInt32 (Console.ReadLine());

double distant = Distant(xPointA, yPointA, xPointB, yPointB);

Console.WriteLine ($"Расстояние между двумя точками {Math.Round(distant, 2, MidpointRounding.ToZero)}");
double Distant (int xA, int yA, int xB, int yB)
{
    return Math.Sqrt (Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
}

