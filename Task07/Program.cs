Console.WriteLine("Введите трехзначное число = ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = number * -1;
}
if (number >= 100 && number <= 999)


{
    int lastnumber = number % 10;
    Console.WriteLine($"Последняя цифра числа {number} --> {lastnumber}");
}
 else Console.WriteLine ("Вы вышли за пределы оговоренного задания");