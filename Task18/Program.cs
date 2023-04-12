// Напишите программу, которая по номеру 
// четверти показывает диапазон значений X и Y


Console.WriteLine("Введите номер четверти");
Console.Write ("Х: ");
int x = Convert.ToInt32(Console.ReadLine());

string quater = Quater (x);


Console.WriteLine ($"Возможен диапазон цифр {quater}");

string Quater (int answer) 
{
    if (x == 1) return "x> 0, y > 0";
    if (x == 2) return "x< 0, y > 0";
    if (x == 3) return "x< 0, y < 0";
    if (x == 4) return "x> 0, y < 0";
    else return "Неверно указана четверть";
}