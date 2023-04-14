// Задайте массив из 12 элементов, заполненных случайными числами от -9 до 9
// Найдите сумму отрицательных и положительных элементов массива
// Например, в массиве [3,9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] 
// сумма положительных числе равна 39, а сумма отрицательных равна -20

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
    if (i < arr.Length-1) Console.Write($"{arr[i]}, ");
    else Console.Write ($"{arr[i]}");
    
}
        Console.WriteLine("]");

}

    int GetSumNegativElements (int [] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] <0) sum += arr[i];
            
        }
        return sum;
    }

    int GetSumPositiveElements (int [] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0) sum += arr[i];
            
        }
        return sum;
    }

 int [] array = CreateArrayRndInt(12, -9, 9);
 PrintArray(array);
  int sumNegativElements = GetSumNegativElements(array);
  int sumPositiveElements= GetSumPositiveElements (array);

  Console.WriteLine($"Сумма положительных элементов равна {sumPositiveElements} сумма отрицательных элементов равна{sumNegativElements}");