// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int [] CreateArrayRndInt(int size, int min, int max)
{
    int [] arr = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max+1);
    }
    return arr;

}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");

    }
    Console.WriteLine("]");

}

int SumElementOodPosition (int [] arr)
{
    int resault = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) resault=resault + arr[i];
    }
 return resault;
} 

int[] array = CreateArrayRndInt(4, 100, 999);
PrintArray(array);
int sumElementOodPosition = SumElementOodPosition(array);
Console.WriteLine(sumElementOodPosition);


