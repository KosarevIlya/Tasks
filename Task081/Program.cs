// Найти максимальное из 9 чисел
int Max (int arg1, int arg2, int arg3)
{
    int resault = arg1;
    if(arg2 > resault) resault = arg2;
    if (arg3 > resault) resault = arg3;
    return resault;
}

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 12;
int b3 = 23;
int c3 = 33;

int max1 = Max (a1, b1, c1);
int max2 = Max (a2, b2, c2);
int max3 = Max (a3, b3, c3);
int max = Max (max1, max2, max2);

Console.WriteLine(max);