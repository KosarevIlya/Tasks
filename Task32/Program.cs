// Напишити программу замены элементов массива: положительные элементы
// замените на соответсвующие отрицательные и наобоброт
// Например [3, -2, 4, -5]    [-3, 2, -4, 5]

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

    void ChancheSign (int [] arr)
    {
            for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = arr[i]*-1;
            
        }
    }

    int[] array = CreateArrayRndInt (12, -9, 9);
    PrintArray(array);
    ChancheSign(array);
    PrintArray (array);