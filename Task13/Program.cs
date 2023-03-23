// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



Console.WriteLine("Ведите трёхзначное число=");
int number = Convert.ToInt32(Console.ReadLine());

if (99 < number)
{
Console .WriteLine 
($"Третьим числом является {ThirdNumber(number)}");
}
else Console.WriteLine("Трeтьей цифры нет");

int ThirdNumber(int num)
{
    while (num > 1000)
    {
    num = num / 10;
    }
        return num % 10;

}