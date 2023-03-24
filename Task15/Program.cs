// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Ведите трёхзначное число=");
int number = Convert.ToInt32(Console.ReadLine());

if (0 < number && number < 8)
{
Console .WriteLine (ThirdNumber(number));
}
else Console.WriteLine("Нет такого дня недели");

bool ThirdNumber(int num)
{
     if (number > 5)

     {
        return true;
     }
      else{
        return false;
      }
     

}