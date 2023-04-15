// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double [] CreateArrayRndDouble(int size, int min, int max)
{
    double [] arr = new double [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max-min) + min;
        arr[i] =Math.Round(num, 1);
    }
    return arr;

}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");

    }
    Console.WriteLine("]");

}

double FindeMaxElement (double [] arr)              //Поиск максимального элемента массива
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
 return max;
} 


double FindeMinElement (double [] arr)              //Поиск минимального элемента массива
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
 return min;
} 

double DifferensBetweenMinMax(double max, double min)
{
    double resault = Math.Round(max - min, 1);
    return resault;
}

double[] array = CreateArrayRndDouble(4, 100, 999);
PrintArrayDouble(array);
double findeMaxElement = FindeMaxElement(array);
double findeMinElement = FindeMinElement (array);
double differensBetweenMinMax = DifferensBetweenMinMax(findeMaxElement, findeMinElement);

Console.WriteLine($"Разница между максимальным элементом массива {findeMaxElement} и минимальным {findeMinElement} составляет {differensBetweenMinMax}");



// int sumElementOodPosition = SumElementOodPosition(array);
// Console.WriteLine(sumElementOodPosition);


