// Задача 37 Найдите произведение пар чисел в одномерном массиве. Парой считается первый и последний
// второй и предпоследний и т.д. Результат запишите в новом массиве. 

// создание массива и его заполнение
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


int[] CompArray(int[] arr)
{
    int size = arr.Length;
    int sizeNewArray = size % 2 == 0 ? size /2 : size / 2 + 1;
    int[] temp =new int[sizeNewArray]; // создание массива
    for (int i = 0; i < temp.Length; i++)
    {
        temp [i] = arr[i] * arr[size - i -1 ];                                // заполняется массив для ввода

    }
    if (size % 2 !=0) temp[sizeNewArray-1] = arr[size /2]; // вводим числов  конец если массив нечетный
    return temp;

}

int[] array = CreateArrayRndInt(9, 0, 10);
PrintArray(array);
int[] resault = CompArray(array);
PrintArray(resault);