// Принять число и проверить, кратно ли оно 23 и 7


Console.WriteLine(" Введите число=");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine (Miltiple(number) ? "да" : "нет"); 
bool Miltiple (int num)

{
    return num % 7 == 0 & num % 23 == 0;
}