// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] CreateArrayFromKeyBoard(int size)
{
    int[] arr = new int[size];
     Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите элемент массива");
        arr[i] = Convert.ToInt32 (Console.ReadLine());
    }
    return arr;
}

int FidenQuantitiPizitivElementsArray(int [] arr)
{
    int sumPositive = 0;
    for (int i = 0; i < arr.Length; i++)
    {
     if (arr[i] > 0) sumPositive = sumPositive + 1;    
    }
    return sumPositive;
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

Console.Write("Прошу ввести планируемый размер массива = ");
int index = Convert.ToInt32(Console.ReadLine());

int [] createArrayFromKeyBoard = CreateArrayFromKeyBoard(index);
PrintArray(createArrayFromKeyBoard);

int sumPositive = FidenQuantitiPizitivElementsArray(createArrayFromKeyBoard);
Console.WriteLine($"Колличество введенных положительных элементов {sumPositive}");