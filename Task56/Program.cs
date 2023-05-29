// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);

        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");


        }
        Console.WriteLine();
    }
}

void PrintArray(int[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {

        Console.Write($"{matrix[i],3} ");


    }
    Console.WriteLine();
}

int[] ArraySumColums(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = array[k] + matrix[i, j];


        }
        k++;
    }
    return array;

}

int MaxCloum (int [] array)
{
    int maxColum = 0;
    int indexMaxColum = 0;
    for (int i = 0; i < array.Length; i++)
    { if (maxColum < array[i]) 
    maxColum = array[i];
    indexMaxColum = i + 1;

        
    }
    return indexMaxColum;
}


int[,] arr2d = CreateMatrixRndInt(3, 3, 0, 5);
Console.WriteLine("Исходная матрица");
PrintMatrix(arr2d);
int[] arr = ArraySumColums(arr2d);
Console.WriteLine("Матрица в виде одномерного массива");
PrintArray(arr);
Console.WriteLine("");
int maxCloum = MaxCloum(arr);
Console.WriteLine($"Строка с максимальной суммой значений = {maxCloum}");
Console.WriteLine("");







