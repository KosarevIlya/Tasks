// Напишите программу по поиску заданного числа в массиве. пример
// 4 -> [4, 5, 6, 6] --> да
// 5 -> [7, 8, 9 ,10] - > нет

Console.WriteLine("Введите число, которое хотите найти в массиве = ");
int number = Convert.ToInt32 (Console.ReadLine());

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

    bool FindeNumber (int [] arr, int num)
    {
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num) return true;
                                   
        }
        return false;
    }
    int [] array = CreateArrayRndInt(12, -9, 9);
    PrintArray(array);
   string findeNumber = FindeNumber(array, number) ? "Число присутсвует в массиве" : "Число не присутсвует в массиве";
    Console.WriteLine (findeNumber);