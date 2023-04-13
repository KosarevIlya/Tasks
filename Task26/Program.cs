// Написать программу, которая посчитывает колличество цифр в чисел
// Например
// 123 - > 3
// 2 - >1
// 2134 - > 4

Console.WriteLine ("Введите значение числа Х =");
int num = Convert.ToInt32 (Console.ReadLine());

int digits = Digits(num);
Console.WriteLine(Digits(num));


int Digits (int numA)
{
if (numA < 0)
{
    numA = numA *(-1);

}
int sum = 0;
while (numA > 0)
{numA = numA /10;
sum = sum + 1;
    
}
return sum;
}