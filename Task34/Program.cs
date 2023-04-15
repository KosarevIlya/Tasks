// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// создание массива и его заполнение
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

int SearshEvenNumber (int [] arr)
{
    int resault = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) resault++;
    }
 return resault;
} 

int[] array = CreateArrayRndInt(6, 100, 999);
PrintArray(array);
int searshEvenNumber = SearshEvenNumber(array);
Console.WriteLine(searshEvenNumber);