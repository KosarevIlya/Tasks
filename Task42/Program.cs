// Задача 42, напишите программу, которая преобразовывает десятичное число в двоичное

Console.WriteLine("Введите десятичное число = ");
int a = Convert.ToInt32(Console.ReadLine());

int TenToTwo(int num)
{
    int num2 = num;                 //Определяет сколько разрядов будет в числе в двоичной системе
    int i = 0;
    for (i = 0; num2 > 1; i++)
    {
        num2 = num2 / 2;
    }

    int size = i + 1;
    int[] array = new int[size];
    for (i = 0; i < size; i++)      //Получает число в виде обратного массива
    {
        array[i] = num % 2;
        num = num / 2;
    }
    int temp = 0;
    for (i = 0; i < size / 2; i++)
    {
        temp = array[i];
        array[i] = array[size - i - 1];
        array[size - i - 1] = temp;
    }
    string res = String.Concat(array); //Преобразование массива в строку
    int resault = Convert.ToInt32(res); //Преобразование массива в число
    return resault;


}


int tenToTwo = TenToTwo(a);
Console.WriteLine($"Десятичное число {a} в двочной системе выглядит как {tenToTwo}");