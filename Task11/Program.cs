// Напишите программму, которая выводит трехзначное число и удаляет второе
// 743 --> 73
// 525 --> 55

int number = new Random().Next (100, 1000);
Console.WriteLine($"Случайное число из отрезка [100, 999] > {number}");



int maxDigit = MaxDigit(number);
Console.WriteLine ($"Число из первой и второй цифры -->{maxDigit}");


int MaxDigit(int num) // 
{
int firstDigit = num / 100;
int secondDigit = num % 10;
int result = firstDigit*10 + secondDigit;
return result;
}