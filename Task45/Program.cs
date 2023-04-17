// Напишите программу, которая будет создавать копию массива с помощью поэлементного копирования

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
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

int [] CopyArray (int [] arr)

{
int[] copyarray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyarray[i] = arr[i];
    }
    return copyarray;

}

int[] array = CreateArrayRndInt(10, -10, 10);
PrintArray(array);

int[] copyArray = CopyArray(array);
copyArray[1] = 15;
PrintArray(copyArray);