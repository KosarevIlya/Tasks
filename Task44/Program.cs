// Не используя рекурсию выведети  первые N числел Фибоначи. Первые два числа Фибоначи 0 и 1
// Если N = 5 -->  0 1 1 2 3
// Если N = 7 --> 0 1 1 2 3 5 8 
// Если N = 3 --> 0 1 1

int[] CreateArrayFibonacci(int num)
{
    int[] arr = new int[num];
    Random rnd = new Random();
    arr[0] =0;
    arr[1] =1;
    for (int i = 2; i < num; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
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

Console.Write("Введите целое число N = ");
int number = Convert.ToInt32(Console.ReadLine());

int[] createArrayFibonacci = CreateArrayFibonacci(number);
PrintArray(createArrayFibonacci);