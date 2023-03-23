// Напишите программу, которая на входе будет принимать два числа и выводить
// является ли первое кратным второму, если не является, то выводить остаток от деления
//  например 34,5 не кратно, остаток 4

// Console.WriteLine(" Введите первое число=");
// int firstnumber = Convert.ToInt32(Console.ReadLine());
// Напишите программу, которая на входе будет принимать два числа и выводить
// является ли первое кратным второму, если не является, то выводить остаток от деления
//  например 34,5 не кратно, остаток 4

Console.WriteLine(" Введите первое число=");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите второе число=");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int remainsDigitis = RemainsDigits( firstnumber, secondNumber );

Console.WriteLine(remainsDigitis == 0 ? "кратно первому числу" : $" некратно, остаток {remainsDigitis}" );

int RemainsDigits(int num1, int num2)
{ 
    return num1 % num2;


}